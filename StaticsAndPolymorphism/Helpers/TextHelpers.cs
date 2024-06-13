﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsAndPolymorphism.Helpers
{
    public static class TextHelpers                     // static klase se ne instanciraju i nad njima pozivamo static metodu, svaki clan static klase mora biti static.
    {                                                   // uglavnom se koriste kao helper metode.


        public static int CapitalLetterUses = 0;


        public static string CapitalFirstLetter(string word)
        {

            CapitalLetterUses++;    // uvecava se na svakom izvrsavanju


            string editedWord = "";

            if (word.Length == 0)
                return "Empty word";

            if (word.Length == 1)
            {
                editedWord = char.ToUpper(word[0]).ToString();      // prvi znak pretvori u veliko slovo
            }
            else
            {
                editedWord = char.ToUpper(word[0]) + word.Substring(1);
            }

            CapitalLetterUses++;    // uvecava samo kada se izvrsi metoda
            return editedWord;
        }

            public static string InvertMeCapitalizedChars(string word)
            {
                // for example word = aLmiR;
                // output = AlMIr

                string editedWord = "";

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                        editedWord += char.ToLower(word[i]);
                    else
                        editedWord += char.ToUpper(word[i]);
                }

                return editedWord;
            }

            public static int NumberOfCapitalLetters(string word)
            {
                int count = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                        count++;
                }

                return count;
            }

        


    }
}
