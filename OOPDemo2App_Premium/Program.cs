using OOPDemo2App.BusinessObjectsLayer;
using OOPDemo2App.RepositoriesLayer;
using OOPDemo2App.ServicesLayer;

namespace OOPDemo2App
{
    public class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Please choose option:");
            Console.WriteLine("1 - Show all categories");
            Console.WriteLine("2 - Add category");
            Console.WriteLine("3 - Update category");
            Console.WriteLine("4 - Delete category");
            Console.WriteLine("5 - Search by id");
            Console.WriteLine("****************************");
            Console.Write("Enter your choice: ");
        }
        static int GetUserChoice()
        {
            PrintMenu();
            int res = 0;
            int.TryParse(Console.ReadLine(), out res);
            return res;
        }
        static void Main(string[] args)
        {
            ICategoryService iCategoryService = new CategoryService();
            int userchoice = 0;
            int categoryID;
            String categoryName;
            Category category;
            do
            {
                userchoice = GetUserChoice();
                Console.WriteLine($"Your choice: {userchoice}");
                switch (userchoice)
                {
                    case 1: showAllCategories(); break;
                    case 2: EnterCategory(); AddCategory(category); showAllCategories(); break;
                    case 3: EnterCategory(); UpdateCategory(category); showAllCategories(); break;
                    case 4: EnterCategory(); DeleteCategory(category); showAllCategories(); break;
                    case 5: EnterCategory(); SearchByCategoryId(categoryID); break;
                }
            } while (userchoice > 0 && userchoice < 6);
            void showAllCategories()
            {
                List<Category> categories = iCategoryService.GetCategories();
                foreach (Category category in categories)
                {
                    Console.WriteLine(category.ToString());
                }
            }

            void EnterCategory()
            {
                Console.Write("Enter category id: ");
                int.TryParse(Console.ReadLine(), out categoryID);
                Console.Write("Enter category name: ");
                categoryName = Console.ReadLine();
                category = new Category() { CategoryID = categoryID, CategoryName = categoryName };
            }

            void AddCategory(Category category)
            {
                iCategoryService.InsertCategory(category);
            }
            void UpdateCategory(Category category)
            {
                iCategoryService.UpdateCategory(category);
            }
            void DeleteCategory(Category category)
            {
                iCategoryService.DeleteCategory(category);
            }
            void SearchByCategoryId(int categoryID)
            {
                Category? cat = iCategoryService.GetCategoryById(categoryID); 
                  Console.WriteLine(cat?.ToString());
            }
        }


    }
}
