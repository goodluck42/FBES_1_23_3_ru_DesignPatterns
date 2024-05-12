using System.Text;

namespace StructuralPatterns.Composite;

public abstract class Control
{
    private List<Control> _children = new();

    public abstract string Name { get; }

    public void AddChild(Control control)
    {
        _children.Add(control);
    }
    
    public void RemoveChild(Control control)
    {
        _children.Remove(control);
    }

    public IReadOnlyCollection<Control> GetChildren()
    {
        return _children;
    }
    
    public virtual string Render()
    {
        var stringBuilder = new StringBuilder();
        
        stringBuilder.Append('<');
        stringBuilder.Append(Name);
        stringBuilder.Append('>');

        foreach (var control in GetChildren())
        {
            stringBuilder.Append(control.Render());
        }
        stringBuilder.Append("</");
        stringBuilder.Append(Name);
        stringBuilder.Append('>');

        return stringBuilder.ToString();
    }
}