﻿//Brandon Robb
// ITSE 1430 Fall 2021
//Adventure Game
using System;

namespace AdventureGame
{
    public class Character
    {

        public int Id { get; }

        public string Name
        {
            get {
                return (_name != null) ? _name : "";
            }

            set {
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

        public int StrengthLevel { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }

        private string _name;
        private string _biography;
        private string _race;
        private string _profession;
        private int _strengthLevel;
        private int _intelligence;
        private int _agility;
        private int _constitution;
        private int _charisma;

        public const int MinimumValue = 1900;
        public const int MinimumAttribute = 0;
        public const int MaximumAttribute = 100;


        public Character Copy ()
        {
            var character = new Character();
            character.Name = Name;
            character.Biography = Biography;
            character.Profession = Profession;
            character.StrengthLevel = StrengthLevel;
            character.Intelligence = Intelligence;
            character.Agility = Agility;
            character.Constitution = Constitution;
            character.Charisma = Charisma;          
            character.Race = Race;
            return character;
        }

        /// <summary>Validates the object.</summary>
        /// <returns>The error, if any.</returns>
        public string Validate ( /* Movie this */ )
        {
            // Title is required
            if (String.IsNullOrEmpty(Name))
                return "Name is required";

            if (String.IsNullOrEmpty(Profession))
                return "Professionss is required";

            if (String.IsNullOrEmpty(Race))
                return "Racess is required";


            if ((StrengthLevel) < 0 || (StrengthLevel) > 100)
                return "Strength Level must be " + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Intelligence) < 0 || (Intelligence) > 100)
                return "Intelligence Level must be " + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Agility) < 0 || (Agility) > 100)
                return "Agility Level must be " + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Constitution) < 0 || (Constitution) > 100)
                return "Constitution Level must be " + MinimumAttribute +" - "+ MaximumAttribute;

            if ((Charisma) < 0 || (Charisma) > 100)
                return "Charisma Level must be " + MinimumAttribute +" - "+ MaximumAttribute;


            return null;
        }

        public override string ToString ()
        {
            return $"{Name} ({Profession}{Race})";
        }

        private void SetDescriptionToTitle ()
        {
            Biography = Name;
        }
    }
}
