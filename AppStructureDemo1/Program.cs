using AppStructureDemo1.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStructureDemo

{
    class Program

    {

        public static void Main(string[] args)

        {
            Console.WriteLine("User: Hello! Where am I?");
            Console.WriteLine("Apps: Hi there! You are in Presentation Layer or Application Layer.");
            Console.WriteLine("Apps: What can I help you?");
            Console.WriteLine("User: I'd like to use CRUD methods with Category");
            Console.WriteLine("Apps: OK, you must use ICategoryService.");
            Console.WriteLine("Apps: ICategoryService is in Service Layer or Business Logic Layer");
            ICategoryService categoryService = new CategoryService();
            CategoryCRUD();
            void CategoryCRUD()
            {
                Console.WriteLine("Call and pass data to ICategoryService CRUD");
                categoryService.CategoryCRUD();
            }
        }
    }
}
