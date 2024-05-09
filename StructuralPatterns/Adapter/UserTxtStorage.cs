namespace StructuralPatterns.Adapter;

public class UserTxtStorage // third party class
{
    public string OutputFileName { get; }

    public UserTxtStorage(string outputFileName)
    {
        OutputFileName = outputFileName;
    }
    
    public void WriteUser(User user)
    {
        using var streamWriter = new StreamWriter(OutputFileName, true);
        
        streamWriter.WriteLine(user.Id);
        streamWriter.WriteLine(user.Login);
        streamWriter.WriteLine(user.Password);
    }
    
    public string ReadUsers()
    {
        using var streamReader = new StreamReader(OutputFileName);

        return streamReader.ReadToEnd();
    }
}