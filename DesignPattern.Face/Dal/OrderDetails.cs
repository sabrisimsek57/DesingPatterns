namespace DesignPattern.Face.Dal
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int? ProductID { get; set; }
        public int? CustomerID { get; set; }
        public  Customer customer { get; set; }
        public  int? OrderID { get; set; }
        public  Order oder { get; set; }
        public  int ProductCount { get; set; }
        public  decimal ProductPrice { get; set; }
        public  decimal ProductTotalPrice { get; set; }
    }
}
