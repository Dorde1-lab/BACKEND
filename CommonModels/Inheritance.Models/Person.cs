using CommonModels.EnumS;


namespace CommonModels.Inheritance.Models
{
    public class Person
    {

        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Hometown { get; set; }
        public Gender Gender { get; set; }  // Enumeracija

        public Person() { }

        public Person(int id, string fName, string lName, DateTime birthDay, string hometown)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Birthday = birthDay;
            Hometown = hometown;
        }


        public  virtual void PrintInfo()
        {
            Console.WriteLine($"{Id} - {FirstName} - {LastName} - {Birthday.ToShortDateString()} - {Hometown}");
        }

        /*    -   Ovo se koristi i ova se pisi kada hocemo da pozovemo u isto vreme ovu metodu za dve klase.
         
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Id} - {FirstName} - {LastName} - {Birthday.ToShortDateString()} - {Hometown}");

        }

        */




    }
}
