namespace OOPDemo2App.BusinessObjectsLayer
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public override string ToString()
        {
            return $"Category(CategoryID: {CategoryID},CategoryName: {CategoryName})";
        }
    }
}