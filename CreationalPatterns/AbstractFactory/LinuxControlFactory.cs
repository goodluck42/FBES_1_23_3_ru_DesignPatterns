namespace CreationalPatterns.AbstractFactory;

public class LinuxControlFactory : IGUIFactory
{
    public Button CreateButton()
    {
        return new LinuxButton();
    }

    public Label CreateLabel()
    {
        return new LinuxLabel();
    }
}