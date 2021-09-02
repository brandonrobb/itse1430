//ITSE 1430
//Movie Library
using System;

namespace MovieLibrary.ConsoleHost
{
    //Main Program
    class Program
    {
        static void Main ( string[] args )
            //GetInput ();

        {
        bool done = false;

        char choice = GetInput();
            if (choice == 'Q')
                done = HandleQuit();

            else if (choice =='A')
            AddMovie();

            else
                Console.WriteLine("Unknown option");
        
           
    }
        static void AddMovie () 
        {

            //Movie details -ignore warnings for now..
            string title = ReadString("Enter the movie title:", true);
              
            string description = ReadString("Enter optional descrition:", false); 

            int runLength = ReadStringInt32("Enter Run Length (in minutes):", 0);     // >= 0
            ;  //OPtional, In minutes, >=0
            int releaseYear = ReadStringInt32 ("Enter Release Year ():",1990);     // >= 0

            double reviewRating; //Optional, 0.0 to 5.0
            string rating = ReadString ; // Optional, MPAA (not enforced)
            bool isClassic; //Optional
        }

        private static int ReadStringInt32 ( string v1, int v2 ) => throw new NotImplementedException();

        private static bool HandleQuit ()
        {
            //return ReadBoolean("Are you sure you want to quit (Y/N)?"))
            //Dispaly a Confirmation
            if (ReadBoolean("Are you sure you want to quit(Y/N)?"))
                return true;

            return false;

            //Return Results
            
        }

        private static bool ReadBoolean ( string message )

            static int ReadInt32 ( string message, int minimumValue )
        {
            Console.Write(message);
            string input = Console.ReadLine();
           // int result = Int32.Parse(input);
           // bool success = Int32.Parse(input); //crashes program
            int result;
            if (Int32.TryParse (input, out result))

                      return result;
            return -1;
        }

       static string ReadString (string message, bool required )
        {
            Console.Write(message);
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
                return true;

            //Todo: Input validation
            string input = Console.ReadLine();
            return false;

        }
        static string ReadString ( string message, bool required )
        {
            Console.Write(message);
            //Todo: Input validatio - required, normalize

            string input = Console.ReadLine();
        }

        static char GetInput ()
        {
            Console.WriteLine("Movie Library");
            Console.WriteLine("---------------");

            Console.Write("A)dd");
            Console.WriteLine("Q)uit");

            //Todo: Input Validation
            //Get input
            string input = Console.ReadLine ();
            if (input =="Q")
                return 'Q';
            else if (input == "A")
                return 'A';

            return default(char);
        }
    }
}
