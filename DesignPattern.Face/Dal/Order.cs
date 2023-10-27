namespace DesignPattern.Face.Dal
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Customer  Customer { get; set; }
        public DateTime  OrderDate { get; set; }

        public List<OrderDetails> OrderDetails { get; set; } 
    }
}
