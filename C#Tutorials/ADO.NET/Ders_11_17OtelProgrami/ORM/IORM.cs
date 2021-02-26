using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public interface IORM<T>
    {
        DataTable Select();
        bool Insert(T ent);
        bool Update(T ent);
        bool Delete(int id);
    }
}
