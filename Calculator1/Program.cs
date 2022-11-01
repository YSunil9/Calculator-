using System.Transactions;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator1 calculator1 = new Calculator1();
            Console.WriteLine("Enter the 1st number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int y = Convert.ToInt32(Console.ReadLine());

            calculator1.AddTwoNumbers(x,y);

        }
    }
}