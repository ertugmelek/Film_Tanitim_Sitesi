using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using FilmSitesi.Entity;

namespace FilmSitesi.Entity.Mapping
{
    public class FilmMapping:EntityTypeConfiguration<Film>
    {
        public FilmMapping ()
	{
            this.ToTable("Film_Tablosu");
            HasKey(f => f.FilmId);



            this.HasMany(f=>f.Turler).WithMany(f=>f.Filmler).Map(f=>{
                f.MapLeftKey("FilmId");
                f.MapRightKey("TurId");
                f.ToTable("TurFilmId");
            });

            this.HasMany(f => f.Oyuncular).WithMany(f => f.Filmler).Map(f =>
            {
                f.MapLeftKey("FilmId");
                f.MapRightKey("OyuncuId");
                f.ToTable("OyuncuFilmId");
            });
            this.HasMany(f => f.Ulkeler).WithMany(f => f.Filmler).Map(f =>
            {
                f.MapLeftKey("FilmId");
                f.MapRightKey("UlkeId");
                f.ToTable("UlkeFilmId");
            });

            this.HasMany(f => f.Yonetmenler).WithMany(f => f.Filmler).Map(f =>
            {
                f.MapLeftKey("FilmId");
                f.MapRightKey("YonetmenId");
                f.ToTable("YonetmenFilmId");
            });
    
	}
        }
}
