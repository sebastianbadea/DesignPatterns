using Strategy.Behaviors.SalesManagement;
using Strategy.Behaviors.UserManagement;

namespace Strategy.UserTypes;

internal class SystemAdmin: User
{
    public SystemAdmin(): base(new SystemAdminUserManagementBehavior(), new AdminSalesManagementBehavior())
    {
        
    }
}
