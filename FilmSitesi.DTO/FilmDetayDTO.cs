using FilmSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DTO
{
    public class FilmDetayDTO
    {
        public int FilmId { get; set; }
        public string FilmAdi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string ResimPath { get; set; }
        public int Suresi { get; set; }
        public int Puani { get; set; }
        public string Aciklama { get; set; }
        public string Dil { get; set; }


        public  ICollection<Oyuncu> Oyuncular { get; set; }
        public  ICollection<Tur> Turler { get; set; }
        public  ICollection<Yonetmen> Yonetmenler { get; set; }
        public  ICollection<Ulke> Ulkeler { get; set; }
        public ICollection<Url> Urller { get; set; }

    }
}
