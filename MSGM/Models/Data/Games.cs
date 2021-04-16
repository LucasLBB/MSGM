using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSGM.Models.Data
{
    public class Games
    {
        public int GamesId { get; set; }
        public string Name { get; set; }
        public string GenreGames { get; set; }
        public string DtLaunch { get; set; }
        public string SM { get; set; }
        public decimal Price { get; set; }
        public string Developer { get; set; }
        public string Available { get; set; }
    }
}
