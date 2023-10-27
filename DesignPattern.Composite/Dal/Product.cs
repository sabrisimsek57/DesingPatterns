namespace DesignPattern.Composite.Dal
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Category category { get; set; }

        public int CategoryID { get; set; }
    }
}
