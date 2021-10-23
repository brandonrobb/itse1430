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
            _txtCharacterName.Text = character.Name;
            _txtBiography.Text = character.Biography;
            _cbProfession.SelectedValue = character.Profession;
            _cbRace.SelectedValue = character.Race;
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
            //Build up a Movie
            var character = new Character();
            character.Name = _txtCharacterName.Text;
            character.Biography = _txtBiography.Text;
            character.Profession = _cbProfession.SelectedText;
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

        private void CharacterForm_Load ( object sender, EventArgs e )
        {

        }
    }
}
