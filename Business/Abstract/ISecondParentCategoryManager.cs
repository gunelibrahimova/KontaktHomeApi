using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISecondParentCategoryManager
    {
        void Add(SecondParentCategory secondparentcategory);
        void Remove(SecondParentCategory secondparentcategory);
        void Update(SecondParentCategory secondparentcategory);
        List<SecondParentCategory> GetAllSecondParentCategories();
        SecondParentCategory GetSecondParentCategoryById(int id);
    }
}
