namespace StructuralPatterns.Composite;

public class ControlFactory : IControlFactory
{
    public Control Create<T>() where T : Control, new()
    {
        return new T();
    }
}