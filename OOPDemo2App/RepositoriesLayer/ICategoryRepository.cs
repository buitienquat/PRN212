using OOPDemo2App.BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo2App.RepositoriesLayer
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        Category? GetCategoryById(int id);
    }
}
