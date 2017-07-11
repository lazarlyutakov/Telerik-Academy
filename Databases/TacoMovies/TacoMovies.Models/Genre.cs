﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TacoMovies.Models
{
    public class Genre
    {
        private ICollection<Movie> movies;

        public Genre()
        {
            this.movies = new HashSet<Movie>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies
        {
            get
            {
                return this.movies;
            }

            set
            {
                this.movies = value;
            }
        }
    }
}
