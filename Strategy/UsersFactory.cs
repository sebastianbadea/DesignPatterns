using Strategy.UserTypes;

namespace Strategy;

internal class UsersFactory
{
    public User Process(string userType) => userType switch
    {
        "System admin" => new SystemAdmin(),
        "User admin" => new UserAdmin(),
        "Sales admin" => new SalesAdmin(),
        "Sales user" => new SalesUser(),
        _ => throw new ArgumentOutOfRangeException(nameof(userType), $"There is no user type defined with this name."),
    };
}
