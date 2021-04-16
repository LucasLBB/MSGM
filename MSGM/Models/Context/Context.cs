using Microsoft.EntityFrameworkCore;
using MSGM.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSGM.Models.ContextMusic
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Music> Musics { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
