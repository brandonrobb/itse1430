// ITSE 1430
// Movie Library

using System.Collections.Generic;

namespace MovieLibrary
{
    public interface IMovieDatabase
    {   //Alway Public
        //Methods, Properties and Events
        //the implementation is not provided
        Movie Add ( Movie movie, out string error );
        void Delete ( int id );
        Movie Get ( int id );
        IEnumerable<Movie> GetAll ();
        string Update ( int id, Movie movie );
    }
}