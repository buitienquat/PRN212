namespace OOPDemo2App.BusinessObjectsLayer
{
    public class Product
    {
        //kiểu dữ liệu có ? => được phép null và ngược lại
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public override string ToString()
        {
            return $"Product (ProductID={ProductID})," +
         $"ProductName ={ProductName}," +
                   $"UnitsInStock ={UnitsInStock}," +
                   $"UnitPrice ={UnitPrice}," +
                   $"CategoryID ={CategoryID})";
        }
    }
}