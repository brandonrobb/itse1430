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

    public partial class MainForm : Form
    {
        #region Construction
        public MainForm ()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers

        //Called when File\Exit is selected
        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            UpdateUI();
        }
        private void OnFileExit ( object sender, EventArgs e )
        {
            //Confirm exit?
            if (!Confirm("Do you want to quit?", "Confirm"))
                return;

            Close();
        }

        //Called when Help\About is selected
        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var dlg = new AboutBox();

            //Blocks until child form is closed
            dlg.ShowDialog();

            //Show displays modeless, not blocking
            //dlg.Show();
            //MessageBox.Show("After Show");
        }

        //Called when Movie\Add is selected
        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var dlg = new AddCharacterForm();
            dlg.StartPosition = FormStartPosition.CenterParent;

            //ShowDialog -> DialogResult
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            //TODO: Save movie            
            _character = dlg.Character;
            UpdateUI();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            if (_character == null)
                return;

            var dlg = new AddCharacterForm();
            dlg.Character = _character;

            //ShowDialog -> DialogResult
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            //TODO: Save movie            
            _character = dlg.Character;
            UpdateUI();
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            if (_character == null)
                return;

            //Confirmation *****Make Sure This Works*******
            if (!Confirm($"Are you sure you want to delete '{_character.Name}'?", "Delete"))
                return;

            //TODO: Delete
            _character = null;
            UpdateUI();
        }
        #endregion

        #region Private Members

        private Character _character;



        private void UpdateUI ()
        {
            //Update movie list            
            var characters = (_character != null) ? new Character[1] : new Character[0];
            if (_character != null)
                characters[0] = _character;

            var bindingSource = new BindingSource();
            bindingSource.DataSource = characters;

            //bind the movies to the listbox
            _listCharacters.DataSource = bindingSource;
        }

        /// <summary>Displays a confirmation dialog.</summary>
        /// <param name="message">The confirmation message.</param>
        /// <param name="title">The confirmation title.</param>
        /// <returns>true if confirmed or false otherwise.</returns>
        private static bool Confirm ( string message, string title )
        {
            return MessageBox.Show(message, title,
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes;
        }

        #endregion



    }
}
