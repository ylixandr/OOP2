using OOP8;
namespace OOP8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Ilya", 72, 130);
            Student st2 = new Student("Nikita", 275, 130);
            Student st3 = new Student("Ilya123", 75, 130);
            Teacher tch1 = new Teacher("Volodko", 85, 20);
            Teacher tch2 = new Teacher("Vishnyakov", 67, 30);
            
            // Лифт для студентов
            //Elevator elevatorForStudent = new Elevator("Mogilev", 200);
            //elevatorForStudent.InfoElevator();
            //elevatorForStudent.AddStudent(st1 as Student);
            //elevatorForStudent.PritnListStudent();
            //elevatorForStudent.AddStudent(st2 as Student);
            //elevatorForStudent.PritnListStudent();
            //Console.WriteLine(elevatorForStudent.Loading());

            // Лифт для учителей 
            Elevator elevatorForTeachers = new Elevator("Vitebsk", 200);
            elevatorForTeachers.InfoElevator();
            elevatorForTeachers.AddTeacher(tch1);
            elevatorForTeachers.PrintListTEachers();
            elevatorForTeachers.AddTeacher(tch2);
            Console.WriteLine(elevatorForTeachers.LoadingTeachers());



        }
    }
    
}
