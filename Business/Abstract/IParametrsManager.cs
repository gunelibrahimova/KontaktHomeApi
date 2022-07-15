using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IParametrsManager
    {
        void Add(Parametrs Parametrs);
        void Remove(Parametrs Parametrs);
        void Update(Parametrs Parametrs);
        Parametrs GetOrderById(int id);
        List<Parametrs> GetAll();
    }
}
