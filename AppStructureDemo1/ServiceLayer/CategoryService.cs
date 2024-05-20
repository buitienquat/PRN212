using AppStructureDemo1.RepositoriesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStructureDemo1.ServiceLayer
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository iCategoryRepository;
        public CategoryService()
        {
            iCategoryRepository = new CategoryRepository();
        }

        public void CategoryCRUD()
        {
            Console.WriteLine("ServiceLayer: CategoryService: Hi there!");
            Console.WriteLine("ServiceLayer: CategoryService: You are in Service Layer or Business Logic Layer!");
            Console.WriteLine("ServiceLayer: CategoryService: I am going to validate data entered from User!");

            Console.WriteLine("ServiceLayer: CategoryService: Your data is OK!");
            Console.WriteLine("ServiceLayer: CategoryService: I am going to call ICategoryRepository");
            Console.WriteLine("ServiceLayer: CategoryService: It is in Repositories Layer");
                 Console.WriteLine("ServiceLayer: categoryService: Call ICategoryRepository CRUD");
                iCategoryRepository.CategoryCRUD();
            }
    }
}
