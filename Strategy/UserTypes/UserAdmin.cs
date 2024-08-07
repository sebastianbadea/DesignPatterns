using Strategy.Behaviors.SalesManagement;
using Strategy.Behaviors.UserManagement;

namespace Strategy.UserTypes;

internal class UserAdmin: User
{
    public UserAdmin() : base(new SystemAdminUserManagementBehavior(), new RegularUserSalesManagementBehavior())
    {
        
    }
}
