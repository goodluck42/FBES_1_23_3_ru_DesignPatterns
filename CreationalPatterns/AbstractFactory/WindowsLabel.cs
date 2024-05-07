namespace CreationalPatterns.AbstractFactory;

public class WindowsLabel : Label
{
    public override string Text { get; set; }
    public override void Render()
    {
        Console.WriteLine("Rendering win32 label");
    }
}