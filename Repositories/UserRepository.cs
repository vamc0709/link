namespace link.Repositories;
public interface UserRepository
{
    Task<User> Create(User Item);
    Task Update(User Item);
    Task Delete(long EmpNum);
    Task<List<User>> GetList();

}
public class UserRepositories : IUserRepository
{
    public UserRepositories()
    {

    }
}

public interface IUserRepository
{
}