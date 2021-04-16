using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSGM.Models
{
    public class Series
    {
        public int SeriesId { get; set; }
        public string Name { get; set; }
        public string GenreSeries { get; set; }
        public string DtLaunch { get; set; }
        public string Seasons { get; set; }
        public string Producer { get; set; }
        public string Available { get; set; }

    }
}
