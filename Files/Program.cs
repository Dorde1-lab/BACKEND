using System.Globalization;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            string newFolder = currentDirectory + "\\Files";

            if (Directory.Exists(newFolder) == false)
            {
                DirectoryInfo folder = Directory.CreateDirectory(newFolder);
            }

            string newFile = newFolder + "\\names.txt";

            if (File.Exists(newFile) == false)
            {
                FileStream file = File.Create(newFile);
                file.Close();
            }

            if (File.Exists(newFile))
            {
                string content = File.ReadAllText(newFile);
            }

            int i = 0;

            while (i < 5)
            {
                Console.WriteLine("Please enter some names in this file.");
                string newNames = Console.ReadLine();

                File.AppendAllText(newFile, "\n" + newNames);
                i++;
            }

            string[] content1 = File.ReadAllLines(newFile);                                            // ReadAllLines - pravi niz stringova

            foreach (string content in content1)
            {
                Console.WriteLine($"{content}");
            }




            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            foreach (char firstChar in alphabet)
            {
                string fileStartingWithLetter = $"\\namesStartingWith_{firstChar}.txt";
                bool helperVar = false;


                foreach (string firstContent in content1)
                {
                    if (firstContent.StartsWith(firstChar.ToString().ToUpper()))
                    {
                        helperVar = true;
                        break;
                    }
                }


                if (helperVar)
                {
                    string wholePath = newFolder + fileStartingWithLetter;


                   // string filePath = Path.Combine(newFolder, fileStartingWithLetter);                   // kako se koristi Path.Combine (kao linija 73 ?) ? 
                                                                                                           // Kako da mi se izbrise sve prethodno sto sam uneo?

                    StreamWriter streamWriter = new StreamWriter(wholePath);

                    using (streamWriter)
                    {
                        foreach (string firstContent in content1)
                        {
                           streamWriter.WriteLine(firstContent);
                        }
                    }
                                                                                                             // Task 4 ostao.
                }
            }
        }
    }
}
