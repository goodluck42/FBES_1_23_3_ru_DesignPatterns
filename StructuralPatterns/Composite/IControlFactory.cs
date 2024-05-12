namespace StructuralPatterns.Composite;

public interface IControlFactory
{
    Control Create<T>()
        where T : Control, new();
}