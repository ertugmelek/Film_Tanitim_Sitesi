using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Oyuncu
    {
        public Oyuncu()
        {
            Filmler=new HashSet<Film>();
        }
        public int OyuncuId { get; set; }
        [Required,MaxLength(50)]
        public string OyuncuAdi { get; set; }
        [Required,MaxLength(50)]
        public string OyuncuSoyadi { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}
