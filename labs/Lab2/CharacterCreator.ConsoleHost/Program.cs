/*
 * FILE HEADER
 * ITSE 1430 FALL 2021
 * BRANDON ROBB
 */

using System;
//User Interface
namespace CharacterCreator.ConsoleHost


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
                switch (choice)
                {
                    case 'Q':
                    {
                        done = HandleQuit();
                        break;
                    };
                    case 'A': AddCharacter(); break;
                    case 'V': ViewCharacter(); break;
                    case 'D': DeleteCharacter(); break;
                    default: DisplayError("Unknown option"); break;
                };
            } while (!done);
        }

        //Using null to represent no movie yet
        static Character character; // = new Movie();

        /// <summary>Deletes the movie, if any.</summary>
        private static void DeleteCharacter ()
        {
            if (character == null)
                return;

            //var newMovie = movie.Copy();

            //Confirm
            if (!ReadBoolean("Are you sure (Y/N)? "))
                return;

            //TODO: Delete movie
            character = null;
        }

        /// <summary>Adds a movie.</summary>
        static void AddCharacter ()
        {
            //Store in a temp variable until validated
            var newCharacter = new Character();

            do
            {
                // newMovie.set_Title(...)
                newCharacter.Title = ReadString("Enter the movie title: ", false);
                newCharacter.Description = ReadString("Enter the optional description: ", false);

                newCharacter.RunLength = ReadInt32("Enter run length (in minutes): ", 0); // >= 0
                newCharacter.ReleaseYear = ReadInt32("Enter the release year (min 1900): ", Character.MinimumReleaseYear); //1900+

                //double reviewRating;  //Optional, 0.0 to 5.0
                newCharacter.Rating = ReadString("Enter the MPAA rating: ", false); //MPAA (not enforced)
                newCharacter.IsClassic = ReadBoolean("Is this a classic (Y/N)? ");       //Optional

                //Validate
                var error = newCharacter.Validate();
                if (String.IsNullOrEmpty(error))
                {
                    //TODO: Save movie
                    character = newCharacter;
                    return;
                };

                DisplayError(error);
            } while (true);
        }

        /// <summary>Displays the entered movie.</summary>
        static void ViewCharacter ()
        {
            //What if they haven't added one yet?
            //if (String.IsNullOrEmpty(movie.title))
            if (character == null)
            {
                Console.WriteLine("No movie available");
                return;
            };

            //movie.get_Title()
            Console.WriteLine($"{character.Title} ({character.ReleaseYear})");
            Console.WriteLine($"Runtime: {character.RunLength} mins");
            Console.WriteLine($"MPAA Rating {character.Rating}");
            Console.WriteLine($"Classic? {character.IsClassic}");
            Console.WriteLine(character.Description);

            if (character.AgeInYears >= 25)
                Console.WriteLine($"{character.AgeInYears}th Anniversary");
            //movie.AgeInYears = 10;
        }

        /// <summary>Handles quit logic.</summary>
        /// <returns>true to quit the program.</returns>
        private static bool HandleQuit ()
        {
            //Display a confirmation
            if (ReadBoolean("Are you sure you want to quit (Y/N)? "))
                return true;

            return false;
        }

        /// <summary>Reads a boolean value as Y/N.</summary>
        /// <param name="message">The message to show.</param>
        /// <returns>The user input.</returns>
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
        }

        /// <summary>Reads an Int32 from the console.</summary>
        /// <param name="message">The message to display.</param>
        /// <param name="minimumValue">The minimum value allowed.</param>
        /// <returns>The integrval value that was entered.</returns>
        static int ReadInt32 ( string message, int minimumValue )
        {
            Console.Write(message);

            //Validate input
            do
            {
                var input = Console.ReadLine();

                if (Int32.TryParse(input, out var result) && result >= minimumValue)
                    return result;

                DisplayError("The value must be an integral value >= " + minimumValue);
            } while (true);
        }

        /// <summary>Reads a string from the console.</summary>
        /// <param name="message">The message to show.</param>
        /// <param name="required">true if the value is required.</param>
        /// <returns>The user input.</returns>
        static string ReadString ( string message, bool required )
        {
            Console.Write(message);

            do
            {
                string input = Console.ReadLine().Trim();

                //Is required
                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                DisplayError("Value is required");
            } while (true);
        }

        /// <summary>Displays an error message.</summary>
        /// <param name="message">The message to show.</param>
        static void DisplayError ( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>Gets user input for menu.</summary>
        /// <returns>The selected option.</returns>
        static char GetInput ()
        {
            Console.WriteLine("Movie Library");
            Console.WriteLine("".PadLeft(15, '-'));

            Console.WriteLine("A) dd");
            Console.WriteLine("V) iew");
            Console.WriteLine("D) elete");
            Console.WriteLine("Q) uit");

            while (true)
            {
                //Get input 
                string input = Console.ReadLine().Trim();
                switch (input.ToUpper())
                {
                    case "C": return 'B';
                    case "Q": return 'Q';
                    case "A": return 'A';
                    case "V": return 'V';
                    case "D": return 'D';
                };

                DisplayError("Invalid input");
            };
        }
    }
}