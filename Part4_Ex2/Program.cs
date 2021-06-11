using System;

namespace Part4_Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Dinh", "Tri", "ThaiBinh", 10, 1000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee.CalculateTheBonus(2));
        }
    }
}