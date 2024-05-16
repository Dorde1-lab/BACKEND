using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask1
{
    public class WebPage : ISearchable
    {

        private string text2;


        public WebPage(string text2)
        {
            this.text2 = text2;
        }
        
        public void Search(string word)
        {
            if (text2.Contains(word))
            {
                Console.WriteLine($"Word '{word}' found in document.");
            } else
            {
                Console.WriteLine($"Word '{word}' not found in document.");
            }
        }




    }
}
