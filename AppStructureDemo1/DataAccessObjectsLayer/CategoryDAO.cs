using AppStructureDemo1.BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStructureDemo1.DataAccessObjectsLayer
{
    public static class CategoryDAO
    {
        private static List<Category> categories = new List<Category>()
        {
            new Category(){CategoryID= 1, CategoryName="hello"}
            , new Category(){CategoryID= 2,CategoryName="FPT"}
        };
       public static void CategoryCRUD() {
            Console.WriteLine("DAOlayer: CategoryDAO: Hi there!");
            Console.WriteLine("DAOlayer: CategoryDAO: You are in Data Access Layer!");
            Console.WriteLine("DAOlayer: CategoryDAO: I am going to connect Data Source");
            Console.WriteLine("DAOlayer: CategoryDAO:I need Category model Business Object Layer");
        }
        public static List<Category> GetCategories()
        {
            Console.WriteLine("DAOlayer: CategoryDAO: query from Data Source");
            return categories;
        }
    }
}
