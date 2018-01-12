using System;

namespace MadLibs
{
    class MainClass
    {
        public static Romeo romeoLib = new Romeo();

        public static void Main(string[] args)
        {
            Console.WriteLine("MadLibs");
            Console.WriteLine();
            Console.WriteLine("By Andrew Whitten");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            MainClass prompt = new MainClass();
            string selection = "";

            prompt.Display();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Choice: ");
                selection = Console.ReadLine();
                prompt.Menu(selection);
            }

        }

         void Display()
        {
           
                Console.WriteLine("Which MadLib do you want to play?");
                Console.WriteLine();
                Console.WriteLine("R for Romeo and Juliet");
                Console.WriteLine("L for Lucy In The Sky With Diamonds.");
                Console.WriteLine("Q to quit.");


        }

       public void Menu(string selection)
        {
            bool quit = false;

            while(!quit)
            {
                switch (selection.ToUpper())
                {
                    case "R":
                        RomeoDisplay();
                        quit = true;
                        break;

                    case "L":
                        break;

                    default:
                        break;
                }
            }
        }

        void RomeoDisplay()
        {

            romeoLib.AddWords();
            Console.WriteLine();
            Console.WriteLine("Press enter to see the MadLib.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Two " + romeoLib.romeoArray.GetValue(0,1) + ", both alike" +
                              "in dignity, In fair " + romeoLib.romeoArray.GetValue(1, 1) + ", where" +
                              "we lay our scene, From ancient " + romeoLib.romeoArray.GetValue(2, 1) + " break");
            Console.WriteLine();
            Console.WriteLine("Press enter to go back to the menu.");
            Console.ReadLine();
            Console.Clear();
            Display();
        }






       
           






       
    }
}
