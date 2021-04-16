using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSGM.Models
{
    public class Music
    {

        public int MusicId { get; set; }
        public string Name { get; set; }
        public string GenreMusic { get; set; }
        public string DtLaunch { get; set; }
        public string Singer { get; set; }
        public string LinkMusic { get; set; }
        public string Available { get; set; }

    }
}
