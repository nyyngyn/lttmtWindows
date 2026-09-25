
using System;
class Program
{
    static void Main(string[] args)
    {
        Employee e = new Employee();
        SaleEmployee s = new SaleEmployee();
        e.CalculatePay();
        s.CalculatePay();
        e = new SaleEmployee();
        e.CalculatePay();
    }
}