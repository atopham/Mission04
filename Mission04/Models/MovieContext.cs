using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04.Models
{
    public class MovieContext : DbContext
    {

        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {
            //leave blank for now
        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    category = "Action/Adventure",
                    title = "The Count of Monte Cristo",
                    year = 2002,
                    director = "Kevin Reynolds",
                    rating = "PG-13",
                    edited = false,
                    lentto = "",
                    notes = "One of the best movies ever made"
                },
                new MovieResponse
                {
                    MovieId = 2,
                    category = "Action/Adventure",
                    title = "The Adventure of Robin Hood",
                    year = 1938,
                    director = "Michael Curtis",
                    rating = "PG",
                    edited = false,
                    lentto = "",
                    notes = "One of the best movies ever made"
                },
                new MovieResponse
                {
                    MovieId = 3,
                    category = "Sci-Fi",
                    title = "Inception",
                    year = 2010,
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    edited = false,
                    lentto = "",
                    notes = "One of the best movies ever made"
                }

            );
        }

        //internal void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void add(MovieResponse mr)
        //{
        //    throw new NotImplementedException();
        //}
    }
    }
