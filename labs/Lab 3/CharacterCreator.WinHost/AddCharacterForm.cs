using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
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
        }

        private void LoadCharacter ( Character character )
        {
            _txtCharacterName.Text = character.CharacterName;
            _txtBiography.Text = character.Biography;
            _cbRating.SelectedValue = character.Rating;
            _txtRunLength.Text = character.RunLength.ToString();
            Agility.Text = character.Agility.ToString();
            _chkIsClassic.Checked = character.IsClassic;
        }

        //Called when Save clicked
        private void OnSave ( object sender, EventArgs e )
        {
            //Build up a Movie
            var character = new Character();
            character.CharacterName = _txtCharacterName.Text;
            character.Biography = _txtBiography.Text;
            character.Rating = _cbRating.SelectedText;
            character.RunLength = GetInt32(_txtRunLength);
            character.Agility = GetInt32(Agility);
            character.IsClassic = _chkIsClassic.Checked;

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

        private void CharacterForm_Load ( object sender, EventArgs e )
        {

        }
    }
}
