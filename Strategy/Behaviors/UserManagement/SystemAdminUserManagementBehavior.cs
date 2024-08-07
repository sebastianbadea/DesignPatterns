using Spectre.Console;

namespace Strategy.Behaviors.UserManagement;

internal class SystemAdminUserManagementBehavior : IUserManagementBehavior
{
    public void ListUsers()
    {
        AnsiConsole.Write(new Markup($"Called {nameof(ListUsers)} from {nameof(SystemAdminUserManagementBehavior)}. [bold green]This type can manage all the users.[/]"));
    }
}
