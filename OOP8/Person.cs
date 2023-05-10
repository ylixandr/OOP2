using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal class Person
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        double mass;
        public double Mass { get { return mass; } set {  mass = value; } }

        public Person (string name, double mass )
        {
            this.name = name;
            this.mass = mass;
        }

        public void Info()
        {
            string inf = $"\nЧеловек" +
                $"\nName: {Name}" +
                $"\nMass: {Mass}" ;
            Console.WriteLine(inf);
        }
    }
}
