namespace CreationalPatterns.Builder.Models;

public record  Ram
{
    public required string Model { get; set; }
    public required int Mhz { get; set; }
    public required int Amount { get; set; }
}