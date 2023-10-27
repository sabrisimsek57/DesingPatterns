using DesignPattern.Face.Dal;
using DesignPattern.Face.FacePattern;

namespace DesignPattern.Face.FacePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetails orderDetails = new OrderDetails();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail AddOrderDetail = new AddOrderDetail();   


        public void CompleteOrderDeatil(int customerID, int productId , int OrderId, 
          decimal productPrice  ,int productCount)
        {
            orderDetails.OrderID = OrderId;

            orderDetails.CustomerID = customerID;
            orderDetails.ProductID = productId;
            orderDetails.ProductCount = productCount;
            orderDetails.ProductPrice = productPrice;
           decimal totatlProductPrice = productCount * productPrice;
            orderDetails.ProductTotalPrice = totatlProductPrice;
            AddOrderDetail.AddNewOrderDetails(orderDetails);

            productStock.StockDecrase(productId, productCount);
        }
        public void CompleteOrder(int customerID)
        {

            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);
        }
    }
}
