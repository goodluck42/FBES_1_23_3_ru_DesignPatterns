namespace StructuralPatterns.Adapter;

public class UserStorageAdapter : IUserStorage
{
    private readonly UserTxtStorage _userTxtStorage;

    public UserStorageAdapter(UserTxtStorage userTxtStorage)
    {
        _userTxtStorage = userTxtStorage;
    }
    
    public void WriteUser(User user)
    {
        _userTxtStorage.WriteUser(user);
    }

    public IEnumerable<User> ReadAllUsers()
    {
        var users = _userTxtStorage.ReadUsers();
        var usersData = users.Split('\n');
        var userList = new List<User>();
        var userLength = usersData.Length / 3;
        
        for (int i = 0; i < userLength; i++)
        {
            var currentUser = new User();
            
            currentUser.Id = Convert.ToInt32(usersData[0 + i * 3]);
            currentUser.Login = usersData[1 + i * 3];
            currentUser.Password = usersData[2 + i * 3];
            
            userList.Add(currentUser);
        }
        
        return userList;
    }
}