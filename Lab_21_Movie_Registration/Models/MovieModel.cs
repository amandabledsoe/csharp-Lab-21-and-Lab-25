using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_21_Movie_Registration.Models
{
    public class MovieModel
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        [Required]
        public string Actors { get; set; }
        [Required]
        public string Directors { get; set; }

        public MovieModel()
        {

        }

        public MovieModel(int id, string title, string genre, int year, string actors, string directors)
        {
            this.ID = id;
            this.Title = title;
            this.Genre = genre;
            this.Year = year;
            this.Actors = actors;
            this.Directors = directors;
        }
    }
}
