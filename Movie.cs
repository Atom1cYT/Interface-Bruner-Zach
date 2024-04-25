using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Interface_Bruner_Zach

    // Implement a constructor that takes string parameters; genre, esrb and title Create automatic properties for ESRB, Genre and Title Assign the parameter to the corresponding property.


{
    class Movie : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

       public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }  
        
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhhh");
        }
        
        public string Describe()
        {
            return $"The movie is {Title} is a {Genre} movie, rated {Esrb}!";

        }


    }
}
