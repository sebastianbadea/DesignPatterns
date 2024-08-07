using Spectre.Console;
using Strategy.Behaviors.UserManagement;

namespace Strategy.Behaviors.SalesManagement;

internal class AdminSalesManagementBehavior : ISalesManagementBehavior
{
    public void AddSales()
    {
        //Console.WriteLine($"Called {nameof(AddSales)} from {nameof(AdminSalesManagementBehavior)}. It is allowed to add a sale.");
        AnsiConsole.Write(new Markup($"Called {nameof(AddSales)} from {nameof(AdminSalesManagementBehavior)}. [bold green]It is allowed to add a sale.[/]"));
    }
}
