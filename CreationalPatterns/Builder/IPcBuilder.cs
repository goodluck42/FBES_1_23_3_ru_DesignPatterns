using System.Reflection.Metadata;
using CreationalPatterns.Builder.Models;

namespace CreationalPatterns.Builder;

public interface IPcBuilder
{
    IPcBuilder AddRam(Ram ram);
    IPcBuilder AddCpu(Cpu cpu);
    IPcBuilder AddGpu(Gpu gpu);
    IPcBuilder AddMotherboard(Motherboard motherboard);
    IPcBuilder AddPsu(Psu psu);
    Pc Build();
    IPcBuilder Reset();
}

public static class PcBuilderHelper
{
    public static void ThrowIfMotherboardIsNull(Motherboard? motherboard)
    {
        _ = motherboard ?? throw new ArgumentException("Motherboard is not set.");
    }
}

public class PcBuilder : IPcBuilder
{
    private int _ramCount;
    private Pc _pc = null!;

    private const int MaxRamCount = 4;

    public PcBuilder()
    {
        Reset();
    }

    public IPcBuilder AddRam(Ram ram)
    {
        PcBuilderHelper.ThrowIfMotherboardIsNull(_pc.Motherboard);

        if (_pc.Motherboard!.Ram == null)
        {
            _pc.Motherboard!.Ram = new Ram[MaxRamCount];
        }

        if (_ramCount < MaxRamCount)
        {
            _pc.Motherboard!.Ram[_ramCount++] = ram;
        }

        return this;
    }

    public IPcBuilder AddCpu(Cpu cpu)
    {
        PcBuilderHelper.ThrowIfMotherboardIsNull(_pc.Motherboard);

        _pc.Motherboard!.Cpu = cpu;

        return this;
    }

    public IPcBuilder AddGpu(Gpu gpu)
    {
        PcBuilderHelper.ThrowIfMotherboardIsNull(_pc.Motherboard);

        _pc.Motherboard!.Gpu = gpu;

        return this;
    }

    public IPcBuilder AddMotherboard(Motherboard motherboard)
    {
        _pc.Motherboard = motherboard;

        return this;
    }

    public IPcBuilder AddPsu(Psu psu)
    {
        _pc.Psu = psu;

        return this;
    }

    public Pc Build()
    {
        var pc = _pc;

        Reset();

        return pc;
    }

    public IPcBuilder Reset()
    {
        _pc = new Pc();
        _ramCount = 0;

        return this;
    }
}