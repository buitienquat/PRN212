using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStructureDemo2.ServiceLayer
{
    public class CategoryService : ICategoryService
    {
        public void CategoryCRUD()
        {
            Console.WriteLine("ServiceLayer: CategoryService: Hi there!");
            Console.WriteLine("ServiceLayer: CategoryService: You are in Service Layer or Business Logic Layer");
            Console.WriteLine("ServiceLayer: CategoryService: I am going to validate date entered form User");

        }
    }
}
