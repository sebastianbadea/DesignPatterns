using Spectre.Console;

namespace Strategy.Behaviors.SalesManagement;

internal class RegularUserSalesManagementBehavior : ISalesManagementBehavior
{
    public void AddSales()
    {
        //Console.WriteLine($"Called {nameof(AddSales)} from {nameof(RegularUserSalesManagementBehavior)}. It is NOT allowed to add any sales.");
        AnsiConsole.Write(new Markup($"Called {nameof(AddSales)} from {nameof(RegularUserSalesManagementBehavior)}. [bold red]It is NOT allowed to add any sales.[/]"));
    }
}
