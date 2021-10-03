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
                    case 'E': EditCharacter(); break;
                    case 'V': ViewCharacter(); break;
                    case 'D': DeleteCharacter(); break;
                    default: DisplayError("Unknown option"); break;
                };
            } while (!done);
        }

        //Using null to represent no movie yet
        static Character s_character; // = new Movie();

        /// <summary>Deletes the movie, if any.</summary>
        private static void DeleteCharacter ()
        {
            if (s_character == null)
                return;

            //var newMovie = movie.Copy();

            //Confirm
            if (!ReadBoolean("Are you sure (Y/N)? "))
                return;

            //TODO: Delete movie
            s_character = null;
        }

        /// <summary>Adds a movie.</summary>
        static void AddCharacter ()
        {
            //Store in a temp variable until validated
            var newCharacter = new Character();

            

            do
            {
                // newMovie.set_Title(...)
                newCharacter.Name = ReadString("Enter the character name: ", false) ; 
                newCharacter.Biography = ReadString("Enter short character biography (optional): ", false);


                newCharacter.Profession = ReadString("Enter character profession: " +
                    "Phychologist, Doctor, Contractor, Athlete, Singer\n", false);


                switch (newCharacter.Profession.ToUpper())
                {
                    //case "fighter":
                    case "PSYCHOLOGIST":
                    break;

                    case "DOCTOR":
                    break;

                    case "CONTRACTOR":
                    break;

                    case "ATHLETE":
                    break;

                    case "SINGER":
                    break;

                    default:
                    DisplayError("Invalid Profession! Profession must be one of the following:\n" +
                        "PSYCHOLOGIST, DOCTOR, CONTRACTOR, ATHLETE, SINGER.");
                    newCharacter.Profession = ReadString("Enter the character profession: ", false);
                    break;

                }
                
                
                newCharacter.Race = ReadString("Enter character race:  " +
                    "Froggler, Doggler, Hoggler, Snakemen, Martian \n", false); 
                                                                                 
                switch (newCharacter.Race.ToUpper())
                {
                    //case "fighter":
                    case "FROGGLER":
                    break;

                    case "DOGGLER":
                    break;

                    case "HOGGLER":
                    break;

                    case "SNAKEMEN":
                    break;

                    case "MARTIAN":
                    break;

                    default:
                    DisplayError("Invalid Race! Race must be one of the following:\n" +
                        "FROGGLER, DOGGLER, HOGGLER, SNAKEMEN, MARTIAN.");
                    newCharacter.Race = ReadString("Enter the character Race: ", false);
                    break;

                }

                newCharacter.StrengthLevel = ReadInt32("Enter a strength level for you character (1-100): ", 1, 100);

                newCharacter.Intelligence = ReadInt32("Enter a intelligence level for you character (1-100): ", 1, 100);

                newCharacter.Agility = ReadInt32("Enter a agility level for you character (1-100): ", 1, 100);

                newCharacter.Constitution = ReadInt32("Enter a constitution level for you character (1-100): ", 1, 100);

                newCharacter.Charisma = ReadInt32("Enter a constitution level for you character (1-100): ", 1, 100);

                //Validate
                var error = newCharacter.Validate();
                if (String.IsNullOrEmpty(error))
                {
                    //TODO: Save movie
                    s_character = newCharacter;
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
            if (s_character == null)
            {
                Console.WriteLine("No character available");
                return;
            };

            //movie.get_Title()
            Console.WriteLine($"{s_character.Name}");
            Console.WriteLine(s_character.Profession);
            Console.WriteLine(s_character.Biography);
            Console.WriteLine($"Race: {s_character.Race}");
            Console.WriteLine($"Strength Level: {s_character.StrengthLevel} ");
            Console.WriteLine($"Intelligence: {s_character.Intelligence} ");
            Console.WriteLine($"Agility: {s_character.Agility} ");
            Console.WriteLine($"Constitution: {s_character.Constitution} ");
            Console.WriteLine($"Charisma: {s_character.Charisma} ");
            //Console.WriteLine($"MPAA Rating {character.Race}");
            //Console.WriteLine($"Classic? {character.IsClassic}");
            
            

           // if (character.AgeInYears >= 25)
             //   Console.WriteLine($"{character.AgeInYears}th Anniversary");
            //movie.AgeInYears = 10;
        }

        static void EditCharacter ()
        {
            ViewCharacter();
            AddCharacter();
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
        static int ReadInt32 ( string message, int minimumValue, int maximumValue )
        {
            Console.Write(message);

            //Validate input
            do
            {
                var input = Console.ReadLine();

                if (Int32.TryParse(input, out var result) && result >= minimumValue && result <= maximumValue)
                    return result;

                DisplayError("The value must be an integral value between " + minimumValue +" - " + maximumValue);
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
            Console.WriteLine("Create Character");
            Console.WriteLine("".PadLeft(15, '-'));

            Console.WriteLine("A) dd");
            Console.WriteLine("E) dit");
            Console.WriteLine("V) iew");
            Console.WriteLine("D) elete");
            Console.WriteLine("Q) uit");

            while (true)
            {
                //Get input 
                string input = Console.ReadLine().Trim();
                switch (input.ToUpper())
                {
                    case "E": return 'E';
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

