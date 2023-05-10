using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal class Elevator
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        double loadCapacity;
        public double LoadCapacity { get { return loadCapacity; } set { loadCapacity = value; } }

        List<Student> countOfStudent = new List<Student>();
        List<Teacher> countOfTeachers = new List<Teacher>();
        public dynamic CountOfPeople { get { return countOfStudent; } set { countOfStudent = value; } }

        public Elevator(string name, double loadCapacity) //Конструктор
        {
            this.name = name;
            this.loadCapacity = loadCapacity;

        }


        public double Loading() //Загруженность лифта
        {
            double mass1 = 0;
            for (int i = 0; i < countOfStudent.Count; i++)
            {
                mass1 = mass1 + countOfStudent[i].Mass;
            }

            return mass1;
        }

        public double LoadingTeachers() //Загруженность лифта учителей
        {
            double mass1 = 0;
            for (int i = 0; i < countOfTeachers.Count; i++)
            {
                mass1 = mass1 + countOfTeachers[i].Mass;
            }

            return mass1;
        }

        public void AddTeacher(Teacher teacher) // Добавить учителя 
        {
            if (LoadingTeachers() < loadCapacity)
            {
                countOfTeachers.Add(teacher);
            }

            else
            {
                Console.WriteLine("Нету места");
            }
        }

        public void PrintListTEachers() // Список учителей в лифте
        {
            for (int i = 0; i < countOfTeachers.Count; i++)
            {
                countOfTeachers[i].Info();
            }
        }




        public void AddStudent(Student student) //Добавление студента
        {
            if (Loading() < loadCapacity)
            {
                countOfStudent.Add(student);
            }

            else
            {
                Console.WriteLine("Лифт перегружен");
            }

        }

        public void PritnListStudent() //Печать списка студентов в лифте
        {
            for (int i = 0; i < countOfStudent.Count; i++)
            {
                countOfStudent[i].Info();
            }
        }
        public void InfoElevator() //Общие сведения о Лифте
        {

            string inf = $"\nName: {Name}" +
            $"\nLoad Capacity: {LoadCapacity}";
            Console.WriteLine(inf);


        }

    }
}
