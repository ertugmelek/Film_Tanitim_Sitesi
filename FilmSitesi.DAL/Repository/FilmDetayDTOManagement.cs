using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSitesi.DTO;
using FilmSitesi.DAL.IRepository;
using FilmSitesi.Entity;

namespace FilmSitesi.DAL.Repository
{
    public class FilmDetayDTOManagement : AbstractManagement, IGet<FilmDetayDTO, int>
    {
        public ICollection<FilmDetayDTO> GetAll()
        {
            ICollection<Film> filmler = _db.Filmler.ToList();
            HashSet<FilmDetayDTO> filmlerim = new HashSet<FilmDetayDTO>();
            foreach (Film film in filmler)
            {
                filmlerim.Add(FilmDetayDoldur(film)).ToString();
            }
            return filmlerim;

        }

        public FilmDetayDTO FilmDetayDTO(int key)
        {
            Film obj = _db.Filmler.Find(key);
            return FilmDetayDoldur(obj);

        }
        private FilmDetayDTO FilmDetayDoldur(Film obj)
        {
            FilmDetayDTO film = new FilmDetayDTO();
            film.FilmId = obj.FilmId;
            film.FilmAdi = obj.FilmAdi;
            film.CikisTarihi = obj.CikisTarihi;
            film.ResimPath = obj.ResimPath;
            film.Dil = obj.Dil;
            film.Ulkeler = obj.Ulkeler;
            film.Oyuncular = obj.Oyuncular;
            film.Turler = obj.Turler;
            film.Aciklama = obj.Aciklama;
            film.Yonetmenler = obj.Yonetmenler;
            film.Urller = obj.Urller;
            return film;
        }


        public FilmDetayDTO Get(int key)
        {
            throw new NotImplementedException();
        }
    }
}
