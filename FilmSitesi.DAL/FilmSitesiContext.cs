using FilmSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL
{
    internal class FilmSitesiContext:DbContext
    {
        public FilmSitesiContext()
            : base("MyConnection")
        {
        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Url> Urller { get; set; }
    }
}
