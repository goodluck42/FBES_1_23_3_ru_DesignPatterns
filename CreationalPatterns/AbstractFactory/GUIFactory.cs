namespace CreationalPatterns.AbstractFactory;

public interface IGUIFactory
{
    Button CreateButton();
    Label CreateLabel();
}

