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

        [Key]
        public int MusicId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string GenreMusic { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string DtLancamento { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Singer { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string LinkMusic { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Available { get; set; }

    }
}
