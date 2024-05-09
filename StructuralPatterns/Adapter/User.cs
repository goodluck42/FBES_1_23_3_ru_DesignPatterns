using System.Text.Json;

namespace StructuralPatterns.Adapter;

public class User
{
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
}

// My services