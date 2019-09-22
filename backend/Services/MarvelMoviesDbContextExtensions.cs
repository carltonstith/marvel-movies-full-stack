using System.Collections.Generic;
using System.Linq;
using MarvelMoviesAPI.Entities;

namespace MarvelMoviesAPI.Services
{
    public static class MarvelMoviesDbContextExtensions
    {
        public static void CreateSeedData(this MarvelMoviesDbContext context)
        {
            if (context.MarvelMovies.Any()) return;

            var MarvelMovies = new List<MarvelMovie>()
            {
                new MarvelMovie()
                {
                    Name = "Captain America: The First Avenger",
                    Year = 2011
                },
                new MarvelMovie()
                {
                    Name = "Captain Marvel",
                    Year = 2019
                },
                new MarvelMovie()
                {
                    Name = "Iron Man",
                    Year = 2008
                },
                new MarvelMovie()
                {
                    Name = "Iron Man 2",
                    Year = 2010
                },
                new MarvelMovie()
                {
                    Name = "The Incredible Hulk",
                    Year = 2008
                },
                new MarvelMovie()
                {
                    Name = "Thor",
                    Year = 2011
                },
                new MarvelMovie()
                {
                    Name = "The Avengers",
                    Year = 2012
                },
                new MarvelMovie()
                {
                    Name = "Thor: The Dark World",
                    Year = 2013
                },
                new MarvelMovie()
                {
                    Name = "Guardians of the Galaxy",
                    Year = 2014
                },
                new MarvelMovie()
                {
                    Name = "Guardians of the Galaxy Vol. 2",
                    Year = 2017
                },
                new MarvelMovie()
                {
                    Name = "Iron Man 3",
                    Year = 2013
                },
                new MarvelMovie()
                {
                    Name = "Captain America: The Winter Soldier",
                    Year = 2014
                },
                new MarvelMovie()
                {
                    Name = "Avengers: Age of Ultron",
                    Year = 2015
                },
                new MarvelMovie()
                {
                    Name = "Ant-Man",
                    Year = 2015
                },
                new MarvelMovie()
                {
                    Name = "Captain America: Civil War",
                    Year = 2016
                },
                new MarvelMovie()
                {
                    Name = "Black Panther",
                    Year = 2018
                },
                new MarvelMovie()
                {
                    Name = "Spider Man: Homecoming",
                    Year = 2017
                },
                new MarvelMovie()
                {
                    Name = "Doctor Strange",
                    Year = 2016
                },
                new MarvelMovie()
                {
                    Name = "Thor: Ragnarok",
                    Year = 2017
                },
                new MarvelMovie()
                {
                    Name = "Ant-Man & the Wasp",
                    Year = 2018
                },
                new MarvelMovie()
                {
                    Name = "Avengers: Infinity War",
                    Year = 2018
                },
                new MarvelMovie()
                {
                    Name = "Avengers: End Game",
                    Year = 2011
                }
            };

            context.AddRange(MarvelMovies);
            context.SaveChanges();
        }
    }
}