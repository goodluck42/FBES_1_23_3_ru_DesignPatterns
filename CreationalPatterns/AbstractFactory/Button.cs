namespace CreationalPatterns.AbstractFactory;

public abstract class Button
{
    public abstract void Render();
    public event Action? Click;
}