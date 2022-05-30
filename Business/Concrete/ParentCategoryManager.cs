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
    public class ParentCategoryManager : IParentCategoryManager
    {
        private readonly IParentCategoryDal _parentCategoryDal;

        public ParentCategoryManager(IParentCategoryDal parentCategoryDal)
        {
            _parentCategoryDal = parentCategoryDal;
        }

        public void Add(ParentCategory parentcategory)
        {
            _parentCategoryDal.Add(parentcategory);
        }

        public List<ParentCategory> GetAllParentCategories()
        {
            return _parentCategoryDal.GetAll();
        }

        public ParentCategory GetParentCategoryById(int id)
        {
            return _parentCategoryDal.Get(x => x.Id == id);
        }

        public void Remove(ParentCategory parentcategory)
        {
            _parentCategoryDal.Delete(parentcategory);
        }

        public void Update(ParentCategory parentcategory)
        {
            _parentCategoryDal.Update(parentcategory);
        }
    }
}
