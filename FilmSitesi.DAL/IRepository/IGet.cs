using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepository
{
    interface IGet<Tvalue, Tkey> where Tvalue : class
    {
        ICollection<Tvalue> GetAll();

        Tvalue Get(Tkey key);
    }
}
