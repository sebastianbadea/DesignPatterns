using Spectre.Console;
using Strategy;
using System.Reflection;

string[] userTypes = ["System admin", "User admin", "Sales admin", "Sales user"];
string[] methods = ["Login", "Logout", "ListUsers", "AddSales"];


while (true)
{
    var userType = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("What's your [green]user type[/]?")
        .PageSize(10)
        .AddChoices(userTypes));

    var user = new UsersFactory().Process(userType);

    var methodToExecute = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("What [green]method[/] you want to execute?")
            .PageSize(10)
            .AddChoices(methods));

    MethodInfo methodInfo = user.GetType().GetMethod(methodToExecute);
    methodInfo?.Invoke(user, null);

    Console.WriteLine();
}

