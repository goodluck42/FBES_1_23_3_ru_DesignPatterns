namespace StructuralPatterns.Adapter;

public interface IUserStorage
{
    void WriteUser(User user);
    IEnumerable<User> ReadAllUsers();
}