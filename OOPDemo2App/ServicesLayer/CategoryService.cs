using OOPDemo2App.BusinessObjectsLayer;
using OOPDemo2App.RepositoriesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo2App.ServicesLayer
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository iCategoryRepository;
        public CategoryService()
        {
            iCategoryRepository = new CategoryRepository();
        }

        public void DeleteCategory(Category category)
        {
            iCategoryRepository.DeleteCategory(category);
        }

        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories();   
        }

        public Category? GetCategoryById(int id)
        {
           return iCategoryRepository.GetCategoryById(id);
        }

        public void InsertCategory(Category category)
        {
            iCategoryRepository.InsertCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            iCategoryRepository.UpdateCategory(category);
        }
    }
}
