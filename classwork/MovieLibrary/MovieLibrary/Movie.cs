using System;   

namespace MovieLibrary
{
    //Naming rules for classes
    //1.Pascal cased
    //2.Never Prefix with t, c or anything
    //3. They are always noun names (describing person, place or thing)
    /// <summary>Do this for all Classes that you Create Represents a movie. </summary>

    public class Movie
    {
        //Fields
        //1. Always camel cased, for now ..
        //2. Should NEVER be public
        //3. Always assigned to null or 0 initially or whatever you set it = to
        //4. Cant initialize to another fields value

        public string title;
        public string description;
        public int runLength;
        public int releaseYear = 1900;
        public double reviewRating;
        public string rating;
        public bool isClassic;

        public const int MinimumReleaseYear = 1900; //Read Only

        //Methods - provide fuctionality (function inside a class)
        // Can ref. fields in methods

        /// <summary>
        /// Copies the movie.
        /// </summary>
        /// <returns>a copy of the movie.</returns>

        public Movie Copy ()
        {
            var movie = new Movie();
            movie.title = title;
            movie.description = description;
            movie.runLength = runLength;
            movie.releaseYear = releaseYear;
            movie.rating = rating;
            movie.isClassic = isClassic;

            return movie;
        }

        public string Validate ()
        {
            //Name is required
            if (String.IsNullOrEmpty(title))
                return "Title is required";

            //Runlength >= 0
            if (runLength < 0)
                return "Run length must be at least zero";

            //Released year >= 1900
            if (releaseYear < MinimumReleaseYear)
                return "Release Year must be at least " + MinimumReleaseYear;
            return null;
        }

        private void SetDescriptionToTitle ()
        {
            description = title;
        }
    }
}
