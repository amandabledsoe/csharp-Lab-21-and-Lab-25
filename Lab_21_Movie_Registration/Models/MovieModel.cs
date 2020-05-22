using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_21_Movie_Registration.Models
{
    public class MovieModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

        public MovieModel()
        {

        }

        public MovieModel(int ID, string Title, string Genre, DateTime Year, string Actors, string Directors)
        {
            this.ID = ID;
            this.Title = Title;
            this.Genre = Genre;
            this.Year = Year;
            this.Actors = Actors;
            this.Directors = Directors;
        }
    }
}
