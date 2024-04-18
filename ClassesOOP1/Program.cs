using classesOOP.Models;

namespace classesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  profesor 1

            Teacher professor1 = new Teacher();

            professor1.Age = 29;
            professor1.FirstName = "Professor";
            professor1.LastName = "Jedan";
            professor1.Email = "professor@gmail.com";
            professor1.LearningModules = new string[] { "C# Basic", " Advanced C#", "DataBase" };

            professor1.SayHello();   // pozivanje metode iz konstruktora;

            professor1.SetYearOfAward("2024");






            //   profesor 2

            Teacher professor2 = new Teacher();

            professor2.Age = 44;
            professor2.FirstName = "Profesor2";
            professor2.LastName = "Dva";
            professor2.Email = "professor2@gmail.com";
            professor2.LearningModules = new string[] { "DataBase Development" };


            Teacher Miroslav = new Teacher();
            Miroslav.Age = 45;

            Teacher Almir = new Teacher();
            Almir.FirstName = "Almir";

            Teacher professor5 = new Teacher();
            Teacher professor6 = new Teacher();
            Teacher professor7 = new Teacher();



        }
    }
}
