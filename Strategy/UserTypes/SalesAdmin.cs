using Strategy.Behaviors.SalesManagement;
using Strategy.Behaviors.UserManagement;

namespace Strategy.UserTypes;

internal class SalesAdmin: User
{
    public SalesAdmin(): base(new SalesAdminUserManagementBehavior(), new AdminSalesManagementBehavior())
    {
        
    }
}
