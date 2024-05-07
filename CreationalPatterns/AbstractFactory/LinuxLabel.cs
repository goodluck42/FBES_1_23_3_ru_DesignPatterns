namespace CreationalPatterns.AbstractFactory;

public class LinuxLabel : Label
{
    public override string Text { get; set; }
    public override void Render()
    {
        Console.WriteLine("Rendering linux label");
    }
}