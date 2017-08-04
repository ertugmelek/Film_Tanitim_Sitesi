using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepository
{
    interface IUpdate<Tvalue, Tkey> where Tvalue : class
    {
        bool Update(Tvalue obj);
        bool Update(Tkey key);
    }
}
