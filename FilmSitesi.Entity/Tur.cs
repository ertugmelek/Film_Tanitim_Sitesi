using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Tur
    {
        public int TurId { get; set; }
        public string TurAdi { get; set; }
        public virtual ICollection<Film> Filmler { get; set; }
    }
}
