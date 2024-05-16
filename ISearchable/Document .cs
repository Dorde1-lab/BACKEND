using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask1
{
    public class Document : ISearchable
    {

        private string text1;
        public Document(string text1)
        {
            this.text1 = text1;
        }

        public void Search(string word)
        {
            if(text1.Contains(word))
            {
                Console.WriteLine($"Word '{word}' found in document.");
            } else
            {
                Console.WriteLine($"Word '{word}' not found in document.");
            }
        }



    }
}
