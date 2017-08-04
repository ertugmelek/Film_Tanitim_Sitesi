using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Yonetmen
    {
        public Yonetmen()
        {
            Filmler = new HashSet<Film>();
        }
        public int YonetmenId { get; set; }
        public string YonetmenAdi { get; set; }
        public string YonetmenSoyadi { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}
