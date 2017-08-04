using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSitesi.DAL.IRepository;
using FilmSitesi.Entity;

namespace FilmSitesi.DAL.Repository
{
    public class FilmManagement:AbstractManagement,ICrudRespository<int,Film>
    {
        
        public bool Add(Film obj)
        {
            try
            {
                _db.Filmler.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(Film obj)
        {
            try
            {
            _db.Filmler.Remove(obj);
            return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Delete(int key)
        {
            try
            {
             Film obj=_db.Filmler.Find(key);
             _db.Filmler.Remove(obj);
             return true;
            }
            catch (Exception)
            {

                return false;
            }
           
           
        }

        public ICollection<Film> GetAll()
        {
           return _db.Filmler.ToList();
        }

        public Film Get(int key)
        {
            return _db.Filmler.Find(key);
        }

        public bool Update(Film obj)
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(int key)
        {
            try
            {
            _db.Filmler.Find(key);
            _db.SaveChanges();
            return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
