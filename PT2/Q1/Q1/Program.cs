using Q1;
using System.Security.Principal;
class Program
{

    private static void Account_SmallAmount(double money, double amount) => Console.WriteLine($"Your withdraw amount {money} is larger than balance {amount}. No withdraw recorded");
    static void Main(string[] args)
    {
        double money;
        Account account = new Account { AccNo = 100, Amount = 2000 };
        account.SmallAmount += Account_SmallAmount;
        Console.WriteLine("OUTPUT:");
        Console.WriteLine(account);

        Console.Write("Deposit:");
        money = double.Parse(Console.ReadLine());
        account.Deposit(money);
        Console.WriteLine(account);

        Console.Write("Withdraw:");
        money = double.Parse(Console.ReadLine());
        account.Withdraw(money);
        Console.WriteLine(account);

        Console.Write("Withdraw:");
        money = double.Parse(Console.ReadLine());
        account.Withdraw(money);
        Console.WriteLine(account);

        Console.Read();
    }
}