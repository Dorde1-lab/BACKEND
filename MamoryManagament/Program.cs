namespace MamoryManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            bool isEnabled = false;
            char  letter = 'a';

            String sentence = new String("some value");

            Student student = new Student();

            student.FirstName = "Zoran";
            student.LastName = "Milanovic";

            Student student2 = new Student();

            student2.FirstName.Substring(0, 10);    

        }
    }
}
