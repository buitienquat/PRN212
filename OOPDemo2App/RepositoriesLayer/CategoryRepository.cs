using OOPDemo2App.BusinessObjectsLayer;
using OOPDemo2App.DataAccessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo2App.RepositoriesLayer
{
    public class CategoryRepository : ICategoryRepository
    {
        public void DeleteCategory(Category category) => CategoryDAO.DeleteCategory(category);      

        public List<Category> GetCategories() => CategoryDAO.GetCategories();
       
        public Category? GetCategoryById(int id) => CategoryDAO.GetProductById(id);
       
        public void InsertCategory(Category category) => CategoryDAO.InsertCategory(category);
        
        public void UpdateCategory(Category category) => CategoryDAO.UpdateCategory(category);
        
    }
}
