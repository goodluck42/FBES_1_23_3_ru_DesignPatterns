using CreationalPatterns.Builder;
using CreationalPatterns.Builder.Models;
using CreationalPatterns.Singleton;

IPcBuilder builder = new PcBuilder();

builder.AddMotherboard(new Motherboard()
{
    Model = "Asus Rog Z650"
});

builder.AddPsu(new Psu()
{
    Model = "KCAS 1000W",
    Watt = 1000
});

builder.AddCpu(new Cpu()
{
    Model = "Intel i7 13700K",
    Cores = 14,
    Ghz = 3.4f
});

builder.AddGpu(new Gpu()
{
    Model = "RTX 4050 Laptop",
    VRam = 6,
    Ghz = 2.5f
});

builder.AddRam(new Ram()
{
    Amount = 16,
    Mhz = 3200,
    Model = "Kingston 16GB 1x16"
});


var pc = builder.Build();

Console.WriteLine(pc.ToString());