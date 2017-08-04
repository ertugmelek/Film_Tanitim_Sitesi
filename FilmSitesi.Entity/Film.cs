using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Film
    {
        public Film()
        {
            Turler = new HashSet<Tur>();
        }
        public int FilmId { get; set; }
        [Required, MaxLength(100)]
        public string FilmAdi { get; set; }
        [Required]
        public DateTime CikisTarihi { get; set; }
        [Required]
        public string ResimPath { get; set; }

        public decimal Suresi { get; set; }
        public decimal Puanı { get; set; }
        public string Dil { get; set; }
        public string Aciklama { get; set; }

        public virtual ICollection<Oyuncu> Oyuncular { get; set; }
        public virtual ICollection<Tur> Turler { get; set; }
        public virtual ICollection<Yonetmen> Yonetmenler { get; set; }
        public virtual ICollection<Ulke> Ulkeler { get; set; }
        public virtual ICollection<Url> Urller { get; set; }
    }
}
