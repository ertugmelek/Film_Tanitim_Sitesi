using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Ulke
    {
        public int UlkeId { get; set; }
        public string UlkeAdi { get; set; }
        public virtual ICollection<Film> Filmler { get; set; }
    }
}
