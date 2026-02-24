using System;

class BankAccount
{
  bool isvalid(double B, double W)
    {
        if (B < W) return false;
        else return true;
    }
    double Deposit(double B, double W)
    {
        if (isvalid(B,W) == true) 
        {
            double ans = B - W;
            return ans;
        }
        else return 0;
    }
}
class Program
{
    static void Main()
    {
        //BankAccount account = new BankAccount();
        Console.WriteLine("Bank account created successfully.");
        Console.WriteLine("Please enter your Deposite");
        double balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the withdrawal amount ");
        double withdrawal = Convert.ToDouble(Console.ReadLine());

        if (isvalid(balance, withdrawal)) { 
            Console.WriteLine("Withdrawal successful!");
   Console.WriteLine($"Remaining Balance : $ {BankAccount.Deposit(balance, withdrawal)}");
        }

}