﻿using System;
using System.Windows.Forms;

namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Additional information after the initialize component constructor
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            //Confirm Exit?
            if (!Confirm("Do you want to quit?", "Confirm"))
                return;

            Close();
        }

        private static bool Confirm (string message, string title)
        {
            return MessageBox.Show(message, title,
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                         == DialogResult.Yes;
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var dlg = new AboutBox();

            //Blocks until child form is closed
            dlg.ShowDialog();

            // Show 
            //dlg.Show();
            //MessageBox.Show("After Show");
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            dlg.ShowDialog();
        }
    }
}
