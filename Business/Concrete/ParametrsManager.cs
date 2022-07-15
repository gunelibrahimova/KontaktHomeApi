using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ParametrsManager : IParametrsManager
    {
        private readonly IParametrsDal _parametrsDal ;

        public ParametrsManager(IParametrsDal parametrsDal)
        {
            _parametrsDal = parametrsDal;
        }

        public void Add(Parametrs Parametrs)
        {
            _parametrsDal.Add(Parametrs);
        }

        public List<Parametrs> GetAll()
        {
           return _parametrsDal.GetAll();

        }

        public Parametrs GetOrderById(int id)
        {
            return _parametrsDal.Get(x => x.Id == id);
        }

        public void Remove(Parametrs Parametrs)
        {
            _parametrsDal.Delete(Parametrs);

        }

        public void Update(Parametrs Parametrs)
        {
            _parametrsDal.Update(Parametrs);

        }
    }
}
