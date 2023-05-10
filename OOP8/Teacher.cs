using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal class Teacher:Person
    {
        int experience;
        public int Experience
        { get { return experience; } set {  experience = value; } }

        public Teacher(string name, double mass, int experience):base(name, mass)
        {
            this.experience = experience;
        }

        new public void Info() //Общие сведения о Учителе
        {
            string inf = $"\nУчитель" +
                $"\nName: {Name}" +
                $"\nMass: {Mass}" +
                $"\nExperience: {Experience}";
            Console.WriteLine(inf);
        }
    }
}
