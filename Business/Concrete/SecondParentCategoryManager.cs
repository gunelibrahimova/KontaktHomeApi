using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SecondParentCategoryManager : ISecondParentCategoryManager
    {
        private readonly ISecondParentCategoryDal _secondParentCategoryDal;

        public SecondParentCategoryManager(ISecondParentCategoryDal secondParentCategoryDal)
        {
            _secondParentCategoryDal = secondParentCategoryDal;
        }

        public void Add(SecondParentCategory secondparentcategory)
        {
           _secondParentCategoryDal.Add(secondparentcategory);
        }

        public List<SecondParentCategory> GetAllSecondParentCategories()
        {
            return _secondParentCategoryDal.GetAll();
        }

        public SecondParentCategory GetSecondParentCategoryById(int id)
        {
            return _secondParentCategoryDal.Get(x=>x.Id == id);
        }

        public void Remove(SecondParentCategory secondparentcategory)
        {
            _secondParentCategoryDal.Delete(secondparentcategory);
        }

        public void Update(SecondParentCategory secondparentcategory)
        {
           _secondParentCategoryDal.Update(secondparentcategory);
        }
    }
}
