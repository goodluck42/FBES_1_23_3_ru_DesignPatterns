namespace CreationalPatterns.Builder.Models;

public record  Motherboard
{
    public required string Model { get; set; }
    public Gpu Gpu { get; set; }
    public Cpu Cpu { get; set; }
    public Ram[]? Ram { get; set; }
}