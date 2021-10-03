using System;

namespace CharacterCreator
{
    public class Character
    {
        //Mixed accessibility - one accessor may be more restrictive
        //public int Id { get; private set; }
        public int Id { get; } //private set ;

        // Properties - methods with field-like syntax, exposes data
        //   Property has a type and name
        //   Properties are Pascal cased and generally public
        //   Property has a getter to read the value and a setter to write the value
        //   Getter must return a value of property type
        //   Setter has a single parameter called `value` of property type
        public string Name
        {
            //Read: T get_Title ()
            get {
                return (_name != null) ? _name : "";
                //if (_title == null)
                //    return "";

                //return _title; 
            }

            //Write void set_Title ( string value ) 
            set {
                //_title = value;
                _name = (value != null) ? value.Trim() : null;
            }
        }

        /// <summary>Gets or sets the description.</summary>
        public string Biography
        {
            get { return (_biography != null) ? _biography : ""; }
            set { _biography = (value != null) ? value.Trim() : null; }
        }

        /// <summary>Gets or sets the description.</summary>
        public string Profession
        {
            get { return (_profession != null) ? _profession : ""; }
            set { _profession = (value != null) ? value.Trim() : null; }
        }
        public string Race
        {
            get { return (_race != null) ? _race : ""; }
            set { _race = (value != null) ? value.Trim() : null; }
        }

        //Full property syntax
        /////////////////public int RunLength
        ///////////{
        //////////    get { return _runLength; }
        // //////   set { _runLength = value; }
        /////}
        //Auto property
        public int StrengthLevel { get; set;}
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }


        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value; }
        //}
        /// <summary>Gets or sets the release year.</summary>
        /// <value>MinimumReleaseYear</value>
        public int ReleaseYear { get; set; } = MinimumReleaseYear;

        //public double ReviewRating
        //{
        //    get { return _reviewRating; }
        //    set { _reviewRating = value; }
        //}
        public double ReviewRating { get; set; }

        public bool IsClassic { get; set; }
        //{
        //    get { return _isClassic; }
        //    set { _isClassic = value; }
        //}

        //TODO: Fix field casing, don't make public
        // Fields
        //  1. Always camel cased
        //  2. Should NEVER be public
        //  3. Always zero initialized or can default
        //  4. Cannot initialize to another field's value
        private string _name;
        private string _biography;
        private string _race;
        private string _profession;
        private int _strengthLevel;
        private int _intelligence;
        private int _agility;
        private int _constitution;
        private int _charisma;

        //TODO: Use the const Luke
        //private int _releaseYear = MinimumReleaseYear;

        //private double _reviewRating;
        //private string _rating;
        //private bool _isClassic;

        // Field is constant and therefore cannot be changed without recompiling
        public const int MinimumReleaseYear = 1900;
        public const int MinimumAttribute = 0;
        public const int MaximumAttribute = 100;

        //public int GetAgeInYears ()
        //{
        //    return DateTime.Now.Year - ReleaseYear;
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
            get { return ReleaseYear < 1922; }
        }

        // Methods - provide functionality (function inside a class)
        //   Can reference fields in method
        //   `this` represents the current instance, always the first parameter (implied)

        /// <summary>Copies the movie.</summary>
        /// <returns>A copy of the movie.</returns>
        public Character Copy ()
        {
            var character = new Character();
           character.Name = Name;
           character.Biography = Biography;
           character.Profession = Profession;
           character.StrengthLevel = StrengthLevel;
           character.ReleaseYear = ReleaseYear;
           character.ReviewRating = ReviewRating;
           character.Race = Race;
           character.IsClassic = IsClassic;

            return character;
        }

        /// <summary>Validates the object.</summary>
        /// <returns>The error, if any.</returns>
        public string Validate ( /* Movie this */ )
        {
            //Title is required
            if (String.IsNullOrEmpty(Name)) // this.title            
                return "Name is required";

            if (String.IsNullOrEmpty(Profession)) // this.title            
                return "Profession is required";

            if (String.IsNullOrEmpty(Race)) // this.title            
                return "Race is required";

            //Run length >= 0
            //if (this.runLength < 0)
            if ( (StrengthLevel) < 0 && (StrengthLevel) > 100)
                return "Strength Level must be" + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Intelligence) < 0 && (Intelligence) > 100)
                return "Intelligence Level must be" + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Agility) < 0 && (Agility) > 100)
                return "Agility Level must be" + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Constitution) < 0 && (Constitution) > 100)
                return "Constitution Level must be" + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Charisma) < 0 && (Charisma) > 100)
                return "Charisma Level must be" + MinimumAttribute +" - "+ MaximumAttribute;

            //Release year >= 1900            
            if (ReleaseYear < MinimumReleaseYear)
                return "Release Year must be at least " + MinimumReleaseYear;

            return null;
        }

        private void SetDescriptionToTitle ()
        {
            Biography = Name;
        }
    }
}
