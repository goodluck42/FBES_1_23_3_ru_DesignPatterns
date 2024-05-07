namespace CreationalPatterns.Builder.Models;

public record  Psu
{
    public required string Model { get; set; }
    public required int Watt { get; set; }
}