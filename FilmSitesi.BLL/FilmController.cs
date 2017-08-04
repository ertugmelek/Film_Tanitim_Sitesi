using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSitesi.DAL.Repository;
using FilmSitesi.Entity;

namespace FilmSitesi.BLL
{
    public class FilmController
    {
        FilmManagement fm;
        public FilmController()
        {
            fm = new FilmManagement();
        }
        public ICollection<Film> VeriGetir()
        {
            return fm.GetAll();
        }
    }
}
