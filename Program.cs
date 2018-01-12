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
                Console.WriteLine();


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

                    case "Q":
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!");
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Please enter one of the choices.");
                        break;
                }
            }
        }

        void RomeoDisplay()
        {
            Console.Clear();
            Console.WriteLine("Please enter some words: ");
            Console.WriteLine();
            romeoLib.AddWords();
            Console.WriteLine();
            Console.WriteLine("Press enter to see the MadLib.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Two " + romeoLib.romeoArray[0,1] + ", both alike " +
                              "in dignity," + "\r\n" + "In fair " + romeoLib.romeoArray[1, 1] + ", " +
                              "where we lay our scene, " + "\r\n" +
                              "From ancient " + romeoLib.romeoArray[2, 1] + " break to new mutiny, " + "\r\n" +
                              "Where civil blood makes civil hands unclean. " + "\r\n" +
                              "From forth the fatal loins of these two foes " + "\r\n" +
                              "A pair of star - cross`d " + romeoLib.romeoArray[3,1] + " take their life; " + "\r\n" +
                              "Whole misadventured piteous overthrows " + "\r\n" +
                              "Do with their " + romeoLib.romeoArray[4, 1] + " bury their parents` strife. " + "\r\n" +
                              "The fearful passage of their " + romeoLib.romeoArray[5, 1] + " love, " + "\r\n" +
                              "And the continuance of their parents` rage, " + "\r\n" +
                              "Which, but their children`s end, nought could " + romeoLib.romeoArray[6, 1] + ", " + "\r\n" +
                              "Is now the " + romeoLib.romeoArray[7, 1] + " hours` traffic of our stage; " + "\r\n" +
                              "The which if you with " + romeoLib.romeoArray[8, 1] + romeoLib.romeoArray[9, 1] + " attend," +
                              "What here shall " + romeoLib.romeoArray[10, 1] + ", " + "\r\n" + "our toil shall strive to mend.");
            
            Console.WriteLine();
            Console.WriteLine("Press enter to go back to the menu.");
            Console.ReadLine();
            Console.Clear();
            Display();
        }






       
           






       
    }
}
