// ITSE 1430
// Movie Library
using System;

namespace MovieLibrary.ConsoleHost
{
    //Main program
    class Program
    {
        //Entry point function
        static void Main ( string[] args )
        {
            
        


            bool done = false;

            do
            {
                char choice = GetInput();
                

                //if (choice == 'Q' || choice == 'q')
                //done = HandleQuit();
                //if (choice == 'Q')
                //    done = HandleQuit();
                //else if (choice == 'A')
                //    AddMovie();
                //else if (choice == 'V')
                //    ViewMovie();
                //else if (choice == 'D')
                //    DeleteMovie();
                //else
                //    Console.WriteLine("Unknown option");
                switch (choice)
                    {
                    case 'Q':
                    {
                        done = HandleQuit(); break;
                    };
                    case 'A': AddMovie(); break;
                    case 'V': ViewMovie(); break;
                    case 'D': DeleteMovie(); break;
                    default: DisplayError("Unknown Option"); break;
                };
            } while (!done);
        }

        static Movie movie; // = new Movie();

        private static void DeleteMovie ()
        {
            if (movie == null)
                return;
            //var newMovie = movie.Copy();

            //Confirm
            if (!ReadBoolean("Are you sure (Y/N)? "))
                return;

            //TODO: delete movie
            movie = null;

            
        }

        

        static void AddMovie ()
        {
            var newMovie = new Movie();

            do
            {
                //Movie details - ignoring warnings for now...
                newMovie.title = ReadString("Enter the movie title: ", true);
                newMovie.description = ReadString("Enter the optional description: ", false);

                newMovie.runLength = ReadInt32("Enter run length (in minutes): ", 0); // >= 0
                newMovie.releaseYear = ReadInt32("Enter the release year (min 1900): ", newMovie.MinimumReleaseYear); //1900+

                //double reviewRating;  //Optional, 0.0 to 5.0
                newMovie.rating = ReadString("Enter the MPAA rating: ", false); //MPAA (not enforced)
                newMovie.isClassic = ReadBoolean("Is this a classic (Y/N)? ");       //Optional

                //Validate
                var error = newMovie.Validate();
                if (!String.IsNullOrEmpty(error))
                {
                    movie = newMovie;
                    return;
                };

                    DisplayError(error);

            }while(true);
        }

        static void ViewMovie ()
        {
            //TODO: What if they haven't added one yet?
           // if (String.IsNullOrEmpty(movie.title))
           if (movie == null)
            {
                Console.WriteLine("No movie available");
                return;
            }
            ////////////////////////////////////////////////////////////////chech below to make sure correct
            //TODO: Formatting
            Console.WriteLine($"{movie.title}({movie.releaseYear})");
            Console.WriteLine($"Runtime: {movie.runLength} mins");
            Console.WriteLine($"MPAA Rating{movie.rating}");
            Console.WriteLine($"Classic? {movie.isClassic}");
            Console.WriteLine(movie.isClassic);
            Console.WriteLine(movie.description);
        }

        //Handles quit logic
        private static bool HandleQuit ()
        {
            //Display a confirmation
            if (ReadBoolean("Are you sure you want to quit (Y/N)? "))
                return true;

            return false;

            //Shortcut of below code, preferred
            //return ReadBoolean("Are you sure you want to quit (Y/N)? ");
        }

        private static bool ReadBoolean ( string message )
        {
            Console.Write(message);

            do
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Y)
                    return true;
                else if (input.Key == ConsoleKey.N)
                    return false;
            } while (true);

            //Not needed anymore
            //return false;
        }
        /// <summary>
        /// Reads an Int 32 from the console.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="minimumValue">The minimum value allowed.</param>
        /// <returns></returns>The integral value that was entered.
        static int ReadInt32 ( string message, int minimumValue )
        {
            Console.Write(message);

            //Validate input
            do
            {
                //var x;
                //string input = Console.ReadLine();
                var input = Console.ReadLine();

                //int result = Int32.Parse(input); //Crashes program, not good for input
                //int result;

                //if string parsed AND result at least min value
                //if (Int32.TryParse(input, out result))
                //    if (result >= minimumValue)
                if (Int32.TryParse(input, out var result) && result >= minimumValue)
                    return result;

                DisplayError("The value must be an integral value >= " + minimumValue);
            } while (true);

            //return -1;
        }

        static string ReadString ( string message, bool required )
        {
            Console.Write(message);

            do
            {
                string input = Console.ReadLine().Trim();

                //TODO: required, normalize
                if (!String.IsNullOrEmpty(input) || !required)

                return input;

                DisplayError("Value is required");
            } while (true);
        }

        static void DisplayError ( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static char GetInput ()
        {
            Console.WriteLine("Movie Library");
            //Console.WriteLine("---------------");
            Console.WriteLine("".PadLeft(15, '-'));

            Console.WriteLine("A) dd");
            Console.WriteLine("V) iew");
            Console.WriteLine("D) elete");
            Console.WriteLine("Q) uit");

            while (true)
            {
                //Get input
                string input = Console.ReadLine().Trim();
                /*if (input == "Q")
                    return 'Q';
                else if (input == "A")
                    return 'A';
                else if (input == "V")
                    return 'V';
                else if (input == "D")
                    return 'D'; */

                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return
                    case "q":
                    case "Q": return 'Q';
                    case "a":
                    case "A": return 'A';
                    case "v":
                    case "V": return 'V';
                    case "d":
                    case "D": return 'D';
                    
                    //default:; 
                };

                DisplayError("Invalid input");
            };

            //return default(char); //default
        }
    }
}