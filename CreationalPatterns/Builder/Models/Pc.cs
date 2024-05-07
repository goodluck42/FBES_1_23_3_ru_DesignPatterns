namespace CreationalPatterns.Builder.Models;

public record  Pc
{
    public Psu? Psu { get; set; }
    public Motherboard? Motherboard { get; set; }
}