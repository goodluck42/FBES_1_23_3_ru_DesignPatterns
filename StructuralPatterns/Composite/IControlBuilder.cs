namespace StructuralPatterns.Composite;

public interface IControlBuilder
{
    IControlBuilder Add<T>(bool isNested = false)
        where T : Control, new();

    Control Build();
}