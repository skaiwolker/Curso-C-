using bytebank_ADM.Employers;
using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee jhon = new Employee();
            jhon.Name = "Jhon";
            jhon.Cpf = "123456789";
            jhon.Balance = 2000;

            Console.WriteLine("Bonification: " + jhon.getBonus());
            Console.ReadLine();
        }
    }
}
