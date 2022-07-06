using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);
        List<Category> GetAllCategories();
        //void AddGetAllIconPath(Category category);
        Category GetCategoryById(int id);

    }
}
