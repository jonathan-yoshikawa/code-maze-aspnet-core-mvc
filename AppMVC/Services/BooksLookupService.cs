using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Services
{
    public class BooksLookupService
    {
        public List<string> GetGenres()
        {
            return new List<string>()
             {
                "Fiction",
                "Thriller",
                "Comedy",
                "Autobiography",
                "Genre1",
                "Genre2"
            };
        }
    }
}
