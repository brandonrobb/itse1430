﻿using System;
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

        public Movie Movie { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            //Always call base version first
            base.OnLoad(e);

            //Load UI, if necessary
            if (Movie != null)
                LoadMovie(Movie);
        }

        private void LoadMovie ( Movie movie )
        {
            _txtTitle.Text = movie.Title;
            _txtDescription.Text = movie.Description;
            _cbRating.SelectedValue = movie.Rating;
            _txtRunLength.Text = movie.RunLength.ToString();
            _txtReleaseYear.Text = movie.ReleaseYear.ToString();
            _chkIsClassic.Checked = movie.IsClassic;
        }

        //Called when Save clicked
        private void OnSave ( object sender, EventArgs e )
        {
            //Build up a Movie
            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Rating = _cbRating.SelectedText;
            movie.RunLength = GetInt32(_txtRunLength);
            movie.ReleaseYear = GetInt32(_txtReleaseYear);
            movie.IsClassic = _chkIsClassic.Checked;

            //Validate
            var error = movie.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                DisplayError(error, "Error");
                DialogResult = DialogResult.None;
                return;
            };

            Movie = movie;

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

        private void MovieForm_Load ( object sender, EventArgs e )
        {

        }
    }
}
