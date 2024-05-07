namespace CreationalPatterns.AbstractFactory;

public class WindowsControlFactory : IGUIFactory
{
    public Button CreateButton()
    {
        return new WindowsButton();
    }

    public Label CreateLabel()
    {
        return new WindowsLabel();
    }
}