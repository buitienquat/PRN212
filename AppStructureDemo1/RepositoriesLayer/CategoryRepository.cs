using AppStructureDemo1.DataAccessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStructureDemo1.RepositoriesLayer
{
    public class CategoryRepository : ICategoryRepository
    {
        public void CategoryCRUD()
        {
            Console.WriteLine("RepositoriesLayer: Category Repository: Hello!");
            Console.WriteLine("RepositoriesLayer: Category Repository: You are in Repositories Layer!");
            Console.WriteLine("RepositoriesLayer: Category Repository: I am a abstraction layer");
            Console.WriteLine("RepositoriesLayer: Category Repository: I am an between Services and DataAccessObject.");

            Console.WriteLine("RepositoriesLayer: Category Repository: I am going call CategoryDAO");
            CategoryDAO.CategoryCRUD();
        }
    }
}




