using System.Collections;

public class Program {
    public static void Main(string[] args) {
        BankAcc bankAcc= new BankAcc();

        Console.WriteLine("Enter the account number: ");
        bankAcc.AccNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ente the owner name: ");
        bankAcc.OwnerName = Console.ReadLine();

        Console.WriteLine("Enter the initial balance: ");
        bankAcc.Balance = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the amount to deposit: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        bankAcc.Deposit(depositAmount);

        Console.WriteLine("Enter the amount to withdraw: ");
        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
        bool success = bankAcc.Withdraw(withdrawAmount);  

        if(success) {
            Console.WriteLine("Deposit and withdrawal successful!");
        }else {
            Console.WriteLine("Withdrawal failed: Insufficient Balance");
        }

        Console.WriteLine($"Account number : {bankAcc.AccNumber}");
        Console.WriteLine($"Owner name: {bankAcc.OwnerName}");
        Console.WriteLine($"Balance: {bankAcc.Balance}");
    }
}