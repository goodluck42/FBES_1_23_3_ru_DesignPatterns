namespace CreationalPatterns.Builder.Models;

public record Cpu
{
    public required string Model { get; init; }
    public required int Cores { get; set; }
    public required float Ghz { get; set; }
}