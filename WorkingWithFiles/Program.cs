namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string absoultePath = "E:\\cv\\SEDC\\BACKEND\\BACKEND\\WorkingWithFiles";

            string currentDirectory = Directory.GetCurrentDirectory();                                             // Directory.GetCurrentDirectory();  - trenutni folder


            Console.WriteLine("Aplikacija se izvrsava u folderu:");
            Console.WriteLine(currentDirectory);



            string newFolderPath = Directory.GetCurrentDirectory() + "\\NoviFolder";                         // Directory.GetCurrentDirectory(); + "\\ novifolder"   -   dodajem novi folder



            if (Directory.Exists(newFolderPath) == false)
            {

                // if directory does not exists, create new one.
                DirectoryInfo directoryInfo = Directory.CreateDirectory(newFolderPath);                      // - ako ne postoji kreiram novi folder

            }
            // path to the new file
            string newFilePath = newFolderPath + "\\test.txt";                                           // puna putanja do fajla


            if (File.Exists(newFilePath) == false)
            {
                // createing new file in C#
                FileStream newFile = File.Create(newFilePath);                                            // ako ne postji fajl, kreiramo ga ovako
                newFile.Close();
            }


            // Delete file if exists                                                                      // brisanje fajla ako treba

            // if(File.Exists (newFilePath))
            //  {
            //     File.Delete(newFilePath);
            // }


            if (File.Exists(newFilePath))
            {
                string content = File.ReadAllText(newFilePath);                 // metoda File.ReadAllText() - cita ceo sadrzaj datoteke sa fajla kao jedan string. Vraca string
                Console.WriteLine(content);                                     // metoda File.ReadAllLines() - cita sve liniju po liniju. Vraca niz stringova.




                Console.WriteLine("Type additional content for this txt:");
                string userInputContent = Console.ReadLine();

                File.AppendAllText(newFilePath, "\n" + userInputContent);        // prvo je file a drugo sadrzaj koji prosledjujemo  - Metoda AppendAllText;     !!!!!!!!!!!!!!



                // Copy from one to another

                string goranTxt = newFolderPath + "\\goran.txt";
                string goranTxtCopy = newFolderPath + "\\noviTextFileZaGoranaCopy.txt";


                // manual copy
                if (File.Exists(goranTxt) == false)
                    File.AppendAllText(goranTxt, content + "... this is edited content");

                // Copy using .NET method
                if (File.Exists(goranTxtCopy) == false)
                    File.Copy(newFilePath, goranTxtCopy);

            }
            Console.WriteLine("..............DONE...........");







            // Working with streams

            string streamFilesFolder = Directory.GetCurrentDirectory() + "\\streams";
            string longTextFile = streamFilesFolder + "\\longText.txt";

            if (Directory.Exists(streamFilesFolder) == false)
            {
                Directory.CreateDirectory(streamFilesFolder);
                Console.WriteLine("The folder created");
            }



            if (File.Exists(longTextFile) == false)
            {
                File.Create(longTextFile).Close();                                       // skracena verzija 
            }

            StreamWriter streamWriter = new StreamWriter(longTextFile);


            using (streamWriter)
            {
                streamWriter.WriteLine("1. Milica");
                streamWriter.WriteLine("2. Goran");
                streamWriter.WriteLine("3. Sava");
                streamWriter.WriteLine("4. Almir");
                streamWriter.WriteLine("5. Milica");
            }


            StreamWriter streamWriterAppend = new StreamWriter(longTextFile, true);       // true zato sto: radi u append nacinu, dodaje na prethodno uz ovo true; bez toga menja a ne dodaje


            using (streamWriterAppend)
            {
                streamWriterAppend.WriteLine("6.Tamara");
                streamWriterAppend.WriteLine("7.Zarko");
            }





            Console.WriteLine(".............Reading the stream - start..........");

            StreamReader streamReader = new StreamReader(longTextFile);

            using (streamReader)
            {
                string firstLine = streamReader.ReadLine();
                string secondLine = streamReader.ReadLine();
                string thirdLine = streamReader.ReadLine();

                string restOfTheContent = streamReader.ReadToEnd();                       // Cita do kraja - Metoda ReadToEnd();


                Console.WriteLine(firstLine);
                Console.WriteLine(secondLine);
                Console.WriteLine(thirdLine);

                Console.WriteLine(restOfTheContent);

            }

            Console.WriteLine(".............Reading the stream - start..........");



            Console.WriteLine("..............DONE...........");






            // Exercise 1



            string currentDirectory1 = Directory.GetCurrentDirectory();
            string folderExercise = currentDirectory1 + "\\Exercise";

            if (Directory.Exists(folderExercise) == false)
            {
                DirectoryInfo directory1 = Directory.CreateDirectory(folderExercise);                              // DirectoryFile
            }



            string fileCalculatios = folderExercise + "\\Calculations";

            if (File.Exists(fileCalculatios) == false)
            {
                FileStream file1 = File.Create(fileCalculatios);
                file1.Close();
            }



            int i = 0;

            using (StreamWriter streamWriterExercise = new StreamWriter(fileCalculatios))
            {

                while (i < 3)
                {
                    Console.WriteLine("Unesi jedan broj");
                    int number1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Unesi drugi broj");
                    int number2 = int.Parse(Console.ReadLine());


                    streamWriterExercise.WriteLine(MethodCalculates(number1, number2));

                    i++;
                }
                
            }




            static string MethodCalculates(int number1, int number2)
            {
                int result = number1 + number2;

                return ($"Broj 1 je: {number1}, broj 2 je: {number2} i rezultat je: {result.ToString()} and date: {DateTime.Now}.");
            }









        }
    }
}
