using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Url
    {
        public int UrlId { get; set; }
        public string UrlAdresi { get; set; }
        public Film film { get; set; }
    }
}
