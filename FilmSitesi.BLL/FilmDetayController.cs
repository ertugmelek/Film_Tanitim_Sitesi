using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSitesi.BLL;
using FilmSitesi.DTO;
using FilmSitesi.DAL.Repository;

namespace FilmSitesi.BLL
{
    public class FilmDetayController
    {
        FilmDetayDTOManagement fdm;
        public FilmDetayController()
        {
            fdm = new FilmDetayDTOManagement();
        }
        public ICollection<FilmDetayDTO> VeriGetir()
        {
            return fdm.GetAll();
        }
    }
}
