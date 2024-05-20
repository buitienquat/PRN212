using OOPDemo2App.BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo2App.DataAccessObjectsLayer
{
    public static class CategoryDAO
    {
        private static List<Category> categories = new List<Category>
        {
            new Category(){CategoryID = 1, CategoryName = "Beveranges" },
            new Category(){CategoryID = 2, CategoryName = "Condiments" },
            new Category(){CategoryID = 3, CategoryName = "Confenctions" }
        };
        public static List<Category> GetCategories () { return categories; }
        public static void InsertCategory(Category category)
        {
            categories.Add(category);
        }
        public static void UpdateCategory(Category category)
        {
            foreach (Category cat in categories.ToList())
            {
                if(cat.CategoryID == category.CategoryID)
                {
                    cat.CategoryID = category.CategoryID;
                    cat.CategoryName = category.CategoryName;
                }
            }
        }
        public static void DeleteCategory(Category category)
        {
            foreach (Category cat in categories.ToList())
            {
                if (cat.CategoryID == category.CategoryID)
                {
                    categories.Remove(cat);
                }
            }
        }
        public static Category? GetProductById(int id)
        {
            foreach(Category cat in categories.ToList())
            {
                if (cat.CategoryID == id)
                {
                    return cat;
                }
            }
            return null;
        }
    }
}
