using Spectre.Console;

namespace Strategy.Behaviors.UserManagement;

internal class RegularUserManagementBehavior : IUserManagementBehavior
{
    public void ListUsers()
    {
        AnsiConsole.Write(new Markup($"Called {nameof(ListUsers)} from {nameof(RegularUserManagementBehavior)}. [bold red]No user management allowed.[/]"));
    }
}
