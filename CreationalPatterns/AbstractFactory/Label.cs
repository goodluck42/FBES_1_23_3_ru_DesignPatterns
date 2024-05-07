namespace CreationalPatterns.AbstractFactory;

public abstract class Label
{
    public abstract string Text { get; set; }

    public abstract void Render();
}