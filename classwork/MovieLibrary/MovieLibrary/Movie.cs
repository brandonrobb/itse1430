using System;   

namespace MovieLibrary
{
    //Naming rules for class
    // 1. Pascal cased
    // 2. Never prefix with T, C or anything else
    // 3. Noun - because they represent an object/entity in your system

    /// <summary>Represents a movie.</summary>

    public class Movie
    {
        //Mixed accessibility - one accessor may be more restrictive
        //public int Id { get; private set; }
        public int Id { get; }//private set;
        public string Title
        {
            // T get_Title ()
            get 
                {

                return (_title != null) ? _title : "";
                //if (_title ==null)
                //    return "";
                //return _title; 

                }

            //Write void set_Title (string value)
            set 
                {

                // _title = value; 
                _title = (value != null) ? value.Trim() : null;
                 }
        }
        //Fields
        //1. Always camel cased, for now ..
        //2. Should NEVER be public
        //3. Always assigned to null or 0 initially or whatever you set it = to
        //4. Cant initialize to another fields value

        /// <summary>
        /// /Gets or sets the description.
        /// </summary>
        public string Description
        {
            // T get_Title ()
            get { return (_description != null) ? _description : ""; }
            set { _description = (value != null) ? value.Trim() : null; }
        }

        public int RunLength
        {
            get; set;
        }

        /// <summary>
        /// Gets the Release Year
        ///  </summary>
        public int ReleaseYear
        {
            get; set;
        } = MinimumReleaseYear;


        public double ReviewRating
        {
            get; set;
        }

        public bool IsClassic
        {
            get; set;
        }
        public string Rating
        {
            // T get_Title ()
            get { return _rating; }
            set { _rating = value; }
        }

        private string _title;
        private string _description;
       // private int _runLength;
       // private int _releaseYear = MinimumReleaseYear;
       // private double _reviewRating;
        private string _rating;
        //private bool _isClassic;

        public const int MinimumReleaseYear = 1900; //Read Only


        //public int GetAgeInYears ()

        //{
        //   return DateTime.Now.Year - ReleaseYear;
        //}
        public int AgeInYears
        {
            get { return DateTime.Now.Year - ReleaseYear; }
            //set { }

        }


        //public bool IsBlackAndWhite ()
        //{

        //    return ReleaseYear < 1922;
        //}

        public bool IsBlackAndWhite
        {
            get { return ReleaseYear < 1922;  }
        }

        //Methods - provide fuctionality (function inside a class)
        // Can ref. fields in methods

        /// <summary>
        /// Copies the movie.
        /// </summary>
        /// <returns>a copy of the movie.</returns>

        public Movie Copy ()
        {
            var movie = new Movie();
            movie.Title = Title;
            movie.Description = Description;
            movie.RunLength = RunLength;
            movie.ReleaseYear = ReleaseYear;
            movie.Rating = Rating;
            movie.IsClassic = IsClassic;

            return movie;
        }

        public string Validate ()
        {
            //Name is required
            if (String.IsNullOrEmpty(Title))
                return "Title is required";

            //Runlength >= 0
            if (RunLength < 0)
                return "Run length must be at least zero";

            //Released year >= 1900
            if (ReleaseYear < MinimumReleaseYear)
                return "Release Year must be at least " + MinimumReleaseYear;
            return null;
        }

        public void SetDescriptionToTitle ()
        {
            Description = Title;
        }
    }
}
