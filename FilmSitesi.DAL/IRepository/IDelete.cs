using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepository
{
    interface IDelete<Tkey, Tvalue> where Tvalue : class
    {
        bool Delete(Tvalue obj);
        bool Delete(Tkey key);
    }
}
