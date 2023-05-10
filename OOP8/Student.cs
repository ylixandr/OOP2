using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal class Student:Person
    {

        decimal scholarShip;
        public decimal ScolarShip { get { return scholarShip; } set { scholarShip = value; } }

        public Student(string name, double mass, decimal scholarShip): base(name, mass) 
        {
            this.scholarShip = scholarShip;
        }

       new public void Info()
        {
            string inf = $"\nСтудент" +
                $"\nName: {Name}" +
                $"\nMass: {Mass}" +
                $"\nScolarship: {ScolarShip}";
            Console.WriteLine(inf);
        }

    }
}
