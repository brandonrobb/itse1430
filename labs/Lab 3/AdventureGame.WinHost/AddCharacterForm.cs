//Brandon Robb
// ITSE 1430 Fall 2021
//Adventure Game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame.WinHost
{
    public partial class AddCharacterForm : Form
    {
        public AddCharacterForm ()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            //Always call base version first
            base.OnLoad(e);

            //Load UI, if necessary
            if (Character != null)
                LoadCharacter(Character);
            ValidateChildren();
        }

        private void LoadCharacter ( Character character )
        {
            _txtCharacterName.Text = character.Name;
            _txtBiography.Text = character.Biography;
            _cbProfession.Text = character.Profession;
            _cbRace.Text = character.Race;
            //_txtRunLength.Text = character.RunLength.ToString();
            _txtStrength.Text = character.StrengthLevel.ToString();
            _txtIntelligence.Text = character.Intelligence.ToString();
            _txtAgility.Text = character.Agility.ToString();
            _txtConstitution.Text = character.Constitution.ToString();
            _txtCharisma.Text = character.Charisma.ToString();
            //_chkIsClassic.Checked = character.IsClassic;
        }

        //Called when Save clicked
        private void OnSave ( object sender, EventArgs e )
        {

            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            };
            //Build up a Movie
            var character = new Character();
            character.Name = _txtCharacterName.Text;
            character.Biography = _txtBiography.Text;
            character.Profession = _cbProfession.Text;
            character.Race = _cbRace.Text;
            //character.RunLength = GetInt32(_txtRunLength);
            character.StrengthLevel = GetInt32(_txtStrength);
            character.Intelligence = GetInt32(_txtIntelligence);
            character.Agility = GetInt32(_txtAgility);
            character.Constitution = GetInt32(_txtConstitution);
            character.Charisma = GetInt32(_txtCharisma);
            //character.IsClassic = _chkIsClassic.Checked;

            //Validate
            var error = character.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                DisplayError(error, "Error");
                DialogResult = DialogResult.None;
                return;
            };

            Character = character;

            //Close the form
            //Close();
        }

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetInt32 ( Control /*TextBox*/ control )
        {
            var text = control.Text;
            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }

        private void _txtTitle_KeyUp ( object sender, KeyEventArgs e )
        {
            var target = sender as TextBox;

            System.Diagnostics.Debug.WriteLine($"KeyUp: Text={target.Name} Key={e.KeyCode}");
        }

        private bool Confirm ( string message, string title )
        {
            return MessageBox.Show(this, message, title,
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes;
        }

        private void OnValidatingName ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as Control;

            //title is required
            if (control.Text.Length > 0)
            {
                _errors.SetError(control, "");
                return;
            };

            //Not valid
            _errors.SetError(control, "Name is required");
            e.Cancel = true;
        }

        private void OnValidatingRaceOrProfession ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as Control;

            //rating is required
            if (control.Text.Length > 0)
            {
                _errors.SetError(control, "");
                return;
            };

            //Not valid
            _errors.SetError(control, "Field is required");
            e.Cancel = true;
        }

        //private void OnValidatingRunLength ( object sender, System.ComponentModel.CancelEventArgs e )
        //{
        //    var control = sender as Control;

        //    //Run length >= 0
        //    var value = GetInt32(control);
        //    if (value >= 0)
        //    {
        //        _errors.SetError(control, "");
        //        return;
        //    };

        //    //Not valid
        //    _errors.SetError(control, "Run Length must be >= 0");
        //    e.Cancel = true;
        //}

        private void OnValidatingAttributeValues ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as Control;

            //Release Year >= MinReleaseYear
            var value = GetInt32(control);
            if (value >= Character.MinimumAttribute)
            {
                _errors.SetError(control, "");
                return;
            };

            //Not valid
            _errors.SetError(control, $"Release Year must be >= {Character.MinimumAttribute} and <= {Character.MaximumAttribute}");
            e.Cancel = true;
        }


        //private void CharacterForm_Load ( object sender, EventArgs e )
        // {

        //}
    }
}
