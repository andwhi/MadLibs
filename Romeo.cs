using System;
namespace MadLibs
{
    public class Romeo
    {
        public string[,] romeoArray = new string[11, 2]
        {
            {"Noun (Plural): ", "" }, {"Place: ", ""}, {"Noun: ", ""},
            {"Noun (Plural): ", ""}, {"Noun: ", ""}, {"Adjective: ", ""},
            {"Verb: ", ""}, {"Number: ", ""}, {"Adjective: ", ""},
            {"Body Part: ", ""}, {"Verb", ""}
        };



        public void AddWords()
        {

            for (int i = 0; i < romeoArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j < romeoArray.GetUpperBound(1); j++)
                {
                    string part = romeoArray[i, j];  

                }
                Console.WriteLine();
                Console.WriteLine(romeoArray.GetValue(i, 0));
                romeoArray.SetValue(Console.ReadLine(), i, 1);

            }

        }

    }


}

