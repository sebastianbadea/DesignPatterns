using Strategy.Behaviors.SalesManagement;
using Strategy.Behaviors.UserManagement;

namespace Strategy.UserTypes;

internal class SalesUser: User
{
    public SalesUser(): base(new RegularUserManagementBehavior(), new AdminSalesManagementBehavior())
    {
        
    }
}
