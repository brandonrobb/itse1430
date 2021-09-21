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
    }
}
