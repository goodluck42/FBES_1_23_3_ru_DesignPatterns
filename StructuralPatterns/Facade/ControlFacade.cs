using System.Net.Mime;
using StructuralPatterns.Composite;

namespace StructuralPatterns.Facade;

public class ControlFacade
{
    private ControlBuilder _controlBuilder;
    private ControlFactory _controlFactory;
    
    public ControlFacade()
    {
        _controlFactory = new ControlFactory();
        _controlBuilder = new ControlBuilder(_controlFactory);
    }
    
    public string RenderCustomControl()
    {
        _controlBuilder.Add<ListBox>()
            .Add<Button>(true)
            .Add<Button>()
            .Add<TextBlock>();

        return _controlBuilder.Build().Render();
    }

    public string RenderSuperButton(string text)
    {
        if (text.Length < 10)
        {
            throw new ArgumentException("Text is too small.");
        }
        
        _controlBuilder.Add<Button>()
            .Add<TextBlock>();
        
        return _controlBuilder.Build().Render();
    }
}