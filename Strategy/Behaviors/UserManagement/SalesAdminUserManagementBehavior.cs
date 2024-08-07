using Spectre.Console;

namespace Strategy.Behaviors.UserManagement;

internal class SalesAdminUserManagementBehavior : IUserManagementBehavior
{
    public void ListUsers()
    {
        //Console.WriteLine($"Called {nameof(ListUsers)} from {nameof(SalesAdminUserManagementBehavior)}. The user management is allowed for sales users.");
        AnsiConsole.Write(new Markup($"Called {nameof(ListUsers)} from {nameof(SalesAdminUserManagementBehavior)}. [bold yellow]The user management is allowed for sales users.[/]"));
    }
}
