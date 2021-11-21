using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4___Collection_generics
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            
            return ("ID: " + ID + " | Name: " + Name + " | Gender: " + Gender + " | Salary: " + Salary);
        }


    }

}
