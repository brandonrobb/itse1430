// ITSE 1430
// Movie Library

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Memory
{
    public class MemoryMovieDatabase
    {
        public MemoryMovieDatabase ()
        {
            //TODO:Seed            
            //Object initializer - creating and initializing new object
            // new T() {
            //   Property1 = Value1,
            //   Property2 = Value2,
            //   ...
            // }
            _items.Add(new Movie() {
                Title = "Jaws",
                Rating = "PG",
                RunLength = 210,
                ReleaseYear = 1977,
                Description = "Shark movie",
                Id = 1,
            });
            
            _items.Add(new Movie() {
                Title = "Dune",
                Rating = "PG",
                ReleaseYear = 1982,
                RunLength = 300,
                Id = 2
            });

        //movie = new Movie() {
        //    Title = "Jaws 2",
        //    Rating = "PG-13",
        //    ReleaseYear = 1979,
        //    RunLength = 190,
        //    Id = 3,
        //};
        _items.Add(new Movie() {
                Title = "Jaws 2",
                Rating = "PG-13",
                ReleaseYear = 1979,
                RunLength = 190,
                Id = 3,
            });
        }

        //TODO: Add 
        public Movie Add ( Movie movie, out string error )
        {
             error = movie.Validate();
            if (!String.IsNullOrEmpty(error))
                return null;
            var existing = FindByTitle (movie.Title);
            if (existing != null)
            {
                error = "Movie cant be nulll";
                    return null;

            }

            var newMovie = movie.Clone();

            newMovie.Id = _nextId++;

            _items.Add(newMovie);

            movie.Id = newMovie.Id;
            return movie;
        }
        private Movie FindByTitle ( string title )
        {
            foreach (var movie in _items)
                if (String.Compare(title, movie.Title, true) ==0)
                    return movie;
            return null;

        }
        private Movie FindById ( int id )
        {
            foreach (var movie in _items)
                if (movie.Id == id)
                    return movie;
            return null;

        }


        //TODO: Update
        public string Update ( int id, Movie movie )
        {

            var error = movie.Validate();
            if (!String.IsNullOrEmpty(error))
                return error;

            var existing = FindById(id);
            if (existing == null)
                return "Movie not found";

            var dup = FindByTitle(movie.Title);
            if (dup != null && dup.Id != id)
            return "Movie must be unique";

            Copy(existing, movie);
            return null;
        }

        private void Copy ( Movie target, Movie source )
        {
            target.Title = source.Title;
            target.Description = source.Description;
            target.Rating = source.Rating;
            target.RunLength = source.RunLength;
            target.ReleaseYear = source.ReleaseYear;
            target.IsClassic = source.IsClassic;
        }

        //TODO: Delete
        public void Delete ( int id )
        {
            var movie = FindById(id);
            if (movie != null)
                _items.Remove(movie);
        }
         
        //TODO: Get
        public Movie Get (int id)
        {
            var movie = FindById(id);

            return movie?.Clone();
        }

        //TODO: Get All
        public Movie[] GetAll ()
        {
           
            //Must clone both array and movies to return new copies
            //Each iteration the next element is copied to the item variable
            //new Movie[0];
            var items = new Movie[_items.Count];
            var index = 0;
            foreach (var item in _items)
            {              
                    items[index++] = item.Clone();
            };

            return items;
        }

        private int _nextId = 1;
        //Arrays are always open in C#
        //Array size is specified at the point of creation
        private List<Movie> _items = new List <Movie>();
    }
}
