using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSGM.Models.Data
{
    public class Movies
    {
        public int MoviesId { get; set; }
        public string Name { get; set; }
        public string GenreMovies { get; set; }
        public string DtLaunch { get; set; }
        public string Duration { get; set; }
        public string Producer { get; set; }
        public string MainCharacters { get; set; }
        public string Available { get; set; }
    }
}
