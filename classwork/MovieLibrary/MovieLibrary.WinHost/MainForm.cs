// ITSE 1430
// Movie Library
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using MovieLibrary.Memory;

namespace MovieLibrary.WinHost
{
     /// <summary>Main window.</summary>
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();

            //Additional init here
            //Runs at design time as well - be careful
        }
        #endregion

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            UpdateUI(true);
        }

        #region Event Handlers

        //Called when File\Exit is selected
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
        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            dlg.StartPosition = FormStartPosition.CenterParent;

            do
            { 
            //ShowDialog -> DialogResult
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Save movie            
            if (_movies.Add(dlg.Movie, out var error) == null)
                DisplayError(error, "Add Failed");
        } while (true);

            UpdateUI();
        }

        //Called when Movie\Edit is selected
        private void OnMovieEdit ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();

            if (movie == null)
                return;

            var dlg = new MovieForm();
            dlg.Movie = movie;
            do { 
            //ShowDialog -> DialogResult
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            //TODO: Save movie            
            var error = _movies.Update(movie.Id, dlg.Movie);
            if (String.IsNullOrEmpty(error))
                break;
            DisplayError(error, "Update Failed");
        }while (true);
            UpdateUI();
        }

        private Movie GetSelectedMovie ()
        {
            return _listMovies.SelectedItem as Movie;
        }


        //Called when Movie\Delete is selected
        private void OnMovieDelete ( object sender, EventArgs e )
        {

           // _movies.IsOnlyAvailbleInMemoryMovieDatabase();
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            //Confirmation
            if (!Confirm($"Are you sure you want to delete '{movie.Title}'?", "Delete"))
                return;

            //TODO: Delete
            _movies.Delete(movie.Id);
            UpdateUI();
        }
        #endregion

        #region Private Members

        //TODO: Remove this...
      

        private IMovieDatabase _movies = new MemoryMovieDatabase();

        /// <summary>Updates UI whenever something has changed.</summary>
        private void UpdateUI ( bool isFirstRun = false)
        {
            //IEnumerable<TextBox> onlyTextBoxes = Controls.OfType<TextBox>();
            //Update movie list            
            var movies = _movies.GetAll();
            if (isFirstRun && !movies.Any())
            {

                if (Confirm("Do you want to seed the database", "Seed"))
                {   
                    _movies.Seed();
                    //SeedDatabase.Seed(_movies);
                    movies = _movies.GetAll();

                    var firstMovie = movies.FirstOrDefault();

                };
            };
           

            var bindingSource = new BindingSource();
            bindingSource.DataSource = movies.ToArray();

            //bind the movies to the listbox
            _listMovies.DataSource = bindingSource;
        }
        
        /// <summary>Displays a confirmation dialog.</summary>
        /// <param name="message">The confirmation message.</param>
        /// <param name="title">The confirmation title.</param>
        /// <returns>true if confirmed or false otherwise.</returns>
        private bool Confirm ( string message, string title )
        {
            return MessageBox.Show(this, message, title,
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes;
        }
        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion        
    }
}