using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Cruella",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 49 Dakika",
                    price = 50,
                    picturePath = basePath + "/cruella.jpeg"
                },
                   new Movie()
                {
                    movieName = "Yeşil Yol",
                    category = Category.macera,
                    minute = "2 Saat 10 Dakika",
                    price = 60,
                    picturePath = basePath + "/greenmile.jpg"
                },
                new Movie()
                {
                    movieName = "Harry Potter",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "/hp.jpg"
                },
                new Movie()
                {
                    movieName = "2012",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "/ikibinoniki.jpg"
                },
                new Movie()
                {
                    movieName = "Smile",
                    category = Category.komedi,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    picturePath = basePath + "/smile.jpg"
                },

             new Movie()
                {
                    movieName = "Megan",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 30 Dakika",
                    price = 200,
                    picturePath = basePath + "/megan.jpg"
                },


            };
        }
    }
}
