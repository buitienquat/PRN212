namespace OOPDemo2App.BusinessObjectsLayer
{
    public class Category
    {
        public int CategoryID{ get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return $"Category(CategoryID: {CategoryID},CategoryName: {CategoryName})";
        }
    }
}