namespace CreationalPatterns.AbstractFactory;

public class WindowsButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Rendering win32 button");
    }
}