#region problem#1

//using System;

//class BankAccount
//{
//   public double balance;
//    public BankAccount(double balance)
//    {
//        this.balance = balance;
//    }
//   public bool isvalid(double B, double W)
//    {
//        if (B < W) return false;
//        else return true;
//    }
//   public double Deposit(double B, double W)
//    {
//        if (isvalid(B, W) == true)
//        {
//            double ans = B - W;
//            return ans;
//        }
//        else return 0;
//    }
//}
//class Program
//{
//    static void Main()
//    {
      
//        Console.WriteLine("Bank account created successfully.");
//        Console.WriteLine("Please enter your Deposite");
//        double balanc = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Please enter the withdrawal amount ");
//        double withdrawal = Convert.ToDouble(Console.ReadLine());

//  BankAccount account = new BankAccount(balanc);

//        if (account.isvalid(balanc, withdrawal))
//        {
//            Console.WriteLine("Withdrawal successful!");
//            Console.WriteLine($"Remaining Balance : $ {account.Deposit(balanc, withdrawal)}");
//        }
//        else Console.WriteLine("Insufficient Funds!");

//    }
//}
#endregion
#region problem#2
//using System;
//using System.Reflection.Metadata.Ecma335;
//struct Calculate_Challenge
//{
//    double sideLength;
//    public Calculate_Challenge(double sideLength)
//    {
//        this.sideLength = sideLength;
//    }
//    public (double Area, double Perimeter) Calculate()
//    {

//        double Area = sideLength* sideLength;
//        double Perimeter = 4 * sideLength;
//        return  (Area, Perimeter);
//    }

//}
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Please enter the side length of the square:");
//        double sideLength = Convert.ToDouble(Console.ReadLine());
//        Calculate_Challenge calculate = new Calculate_Challenge(sideLength);
//        var result = calculate.Calculate();
//        Console.WriteLine($"Area: {result.Area}");
//        Console.WriteLine($"Perimeter: {result.Perimeter}");
//    }
//}

#endregion
