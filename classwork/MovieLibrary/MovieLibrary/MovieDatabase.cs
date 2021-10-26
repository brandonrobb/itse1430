using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieDatabase
    {
        //Add a movie
        public void Add ( Movie movie )
        {

        }
        //Update
        public void Update ( Movie movie )
        {

        }
        //Delete
        public void Delete ( Movie movie )
        {

        }

        //Get
        public Movie Get ()
        {
            return null;
        }

        //Get All
        public Movie[] GetAll ()
        {
            var count 0;

        };
            public class MovieDatabase ()
        { 
        //Todo:Seed
            _items[2] = new Movie () 
            {
                  Title = "Jaws",
                  Rating = "PG-13",
                  ReleaseYear = 1979,
                  RunLength = 190,
                  Id = 3,
            };
    
                

         

            //Never do thiss
            //return _items;
            //******Array.Copy() - will copy array but not ref movies****
            //Must clone both array and movies to return new copies
            var items = new Movie[_items.Length];
            //Dont need the for loop
            //for (int index = 0; index < _items.Length; ++index)
            // items[index] = Copy(_items[index]);
            //Each iteration the next element is copied to the item variable
            //3 limitations
            // No index (use a simple index variable)
            // Item is read only
            //Array cannot change for the life of the loop(keep a separate list)


            var index = 0;
            foreach (var item in _items)
            {
                //item = new Movie();
                items[index++] = item.Clone();
            };

            return items;

        }

        //Arrays are always open in C#
        //Array size is specified at the point of creation
        private Movie[] _items = new Movie[100];

    }
}
