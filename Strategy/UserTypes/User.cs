using Strategy.Behaviors.SalesManagement;
using Strategy.Behaviors.UserManagement;

namespace Strategy.UserTypes;

internal class User
{
    private readonly IUserManagementBehavior _userManagementBehavior;
    private readonly ISalesManagementBehavior _salesManagementBehavior;

    protected User(IUserManagementBehavior userManagementBehavior, ISalesManagementBehavior salesManagementBehavior)
    {
        _userManagementBehavior = userManagementBehavior;
        _salesManagementBehavior = salesManagementBehavior;
    }

    public virtual void Login() => Console.WriteLine($"Login from {nameof(User)}");
    public virtual void Logout() => Console.WriteLine($"Logout from {nameof(User)}");
    public virtual void ListUsers() => _userManagementBehavior.ListUsers();
    public virtual void AddSales() => _salesManagementBehavior.AddSales();
}
