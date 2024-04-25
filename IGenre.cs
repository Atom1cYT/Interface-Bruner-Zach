using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Bruner_Zach
{
    // Implements A constructor that takes string parameters genre esrb and title
    interface IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }


        public string Describe();
    }
}
