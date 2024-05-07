namespace CreationalPatterns.AbstractFactory;

public class LinuxButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Rendering linux button");
    }
}