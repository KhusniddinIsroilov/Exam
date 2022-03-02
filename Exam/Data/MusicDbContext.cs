using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Singer> Singers { get; set; }

        public DbSet<Music> Musics { get; set; }

        public DbSet<Playlist> Playlists { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.CONNECTION_STRING);
        }
    }
}
