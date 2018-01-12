using System;
using System.Collections.Generic;
namespace MadLibs
{
      class MadLibFrame
    {
       

        public string[,] romeoArray = new string[11, 2]
        {
            {"Noun (Plural): ", "" }, {"Place: ", ""}, {"Noun: ", ""},
            {"Noun (Plural): ", ""}, {"Noun: ", ""}, {"Adjective: ", ""},
            {"Verb: ", ""}, {"Number: ", ""}, {"Adjective: ", ""},
            {"Body Part: ", ""}, {"Verb", ""}
        };

        public string[,] lucyArray = new string[11, 2]
        {
            {"Noun (Plural): ", "" }, {"Place: ", ""}, {"Noun: ", ""},
            {"Noun (Plural): ", ""}, {"Noun: ", ""}, {"Adjective: ", ""},
            {"Verb: ", ""}, {"Number: ", ""}, {"Adjective: ", ""},
            {"Body Part: ", ""}, {"Verb", ""}
        };

        public string[,] thisArray = new string[,] { };



        public void AddWords()
        {
           
            for (int i = 0; i < thisArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j < thisArray.GetUpperBound(1); j++)
                {
                    string part = thisArray[i, j];  

                }
                Console.WriteLine();
                Console.WriteLine(thisArray.GetValue(i, 0));
                thisArray.SetValue(Console.ReadLine(), i, 1);


            }

           
        }

    }


}

