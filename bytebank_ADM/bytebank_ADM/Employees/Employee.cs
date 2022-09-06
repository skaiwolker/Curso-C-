using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Employers
{
    public class Employee
    {
        public string Name{ get; set; }

        public string Cpf { get; set; }

        public double Balance { get; set; }


        public double getBonus()
        {
            return Balance * 0.1;
        }
    }
}
