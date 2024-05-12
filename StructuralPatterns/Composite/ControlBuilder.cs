namespace StructuralPatterns.Composite;

public class ControlBuilder(IControlFactory factory) : IControlBuilder
{
    private Control? _root;
    private Control? _current;
    
    public IControlBuilder Add<T>(bool isNested = false) where T : Control, new()
    {
        var control = factory.Create<T>();

        if (_root == null)
        {
            _root = control;
        }
        
        if (_current == null)
        {
            _current = control;

            return this;
        }

        _current.AddChild(control);

        if (isNested)
        {
            _current = control;
        }

        return this;
    }

    public Control Build()
    {
        if (_root == null)
        {
            throw new InvalidOperationException("Cannot build Control. At least one Control required.");
        }

        var tempRoot = _root;

        _root = _current = null;
        
        return tempRoot;
    }
}