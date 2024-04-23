

using CommonModels.EnumS;
using CommonModels.Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();

            student1.Id = 1;
            student1.FirstName = "Test";
            student1.LastName = "Testic";
            student1.Hometown = "Beograd";
            student1.Birthday = new DateTime(2000, 1, 1);
            student1.Gender = Gender.Unknown;                // enumeracija

            student1.UniqueStudentID = "ID932715";
            student1.AverageGrade = 9.5;
            student1.AttendingCourses = new string[] { "Math", "Programming 1" };




            Professor professor1 = new Professor();

            professor1.Id = 2;
            professor1.LastName = "Mara";
            professor1.LastName = "Profi1";
            professor1.Birthday = new DateTime(1950, 1, 1);
            professor1.Hometown = "Belgrade";
            professor1.Biography = "Lorem...";
            professor1.Materials = new string[] { "Pera", "mara" };
            professor1.LecturingCourses = new string[] { "Math", "Language" };
            professor1.Status = ProfessorStatus.Active;       // Enumeracija 

            student1.PrintInfo();
            professor1.PrintInfo(); // ovo je druga klasa....

            if(student1.Gender == Gender.Male)
            {
                Console.WriteLine("Student1 je musko");
            }
            else
            {
                Console.WriteLine("it doesn't metter");
            }


            


        }
    }
}
