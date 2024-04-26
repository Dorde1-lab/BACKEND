

namespace CommonModels.Inheritance.Models

{

    public class Student : Person
    {
                


             //    na ovaj nacin se nasledjuje konstruktor, moze se i on definisati.
/*
        public Student() { }

        public Student( int Id, string fName, string lName, DateTime birthDay, string hometown, string uniqueStudentId, string[] attendingCourses, double averageGrade) : base(Id, fName, lName, birthDay, hometown)
        {
            uniqueStudentId = uniqueStudentId;
            averageGrade = averageGrade;
            averageGrade = averageGrade;
        }

        */


        public string UniqueStudentID { get; set; }
        public string[] AttendingCourses { get; set; }
        public double AverageGrade { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();

            Console.WriteLine($"{UniqueStudentID} - {AverageGrade}");

            Console.WriteLine("Student, Attending Courses");

            foreach (string course in AttendingCourses)
                Console.WriteLine(course);
        }

    }
}
