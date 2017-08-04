using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepository
{
    interface IAdd<T> where T : class
    {
        bool Add(T obj);
    }
}
