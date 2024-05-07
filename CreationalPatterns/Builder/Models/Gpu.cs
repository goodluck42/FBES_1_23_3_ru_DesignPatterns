namespace CreationalPatterns.Builder.Models;

public record  Gpu
{
    public required string Model { get; init; }
    public required int VRam { get; set; }
    public required float Ghz { get; set; }
}