using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.WinHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        //Called when Save clicked
        private void OnSave ( object sender, EventArgs e )
        {
            //Build up a Movie
            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Rating = _cbRating.SelectedText;

            //Validate

            //Return Movie

            // Close Form
            Close();
        }
    }
}
