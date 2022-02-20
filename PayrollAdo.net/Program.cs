using System;

namespace PayrollAdo.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retrieve data from database!");
            Payroll.Retrieve();
        }
    }
}
