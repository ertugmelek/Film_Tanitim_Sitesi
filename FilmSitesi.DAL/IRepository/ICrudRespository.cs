using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepository
{
    interface ICrudRespository<Tkey, Tvalue> : IAdd<Tvalue>, IDelete<Tkey, Tvalue>, IGet<Tvalue, Tkey>, IUpdate<Tvalue, Tkey> where Tvalue : class
    {
    }
}
