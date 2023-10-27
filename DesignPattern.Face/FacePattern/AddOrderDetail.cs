using DesignPattern.Face.Dal;

namespace DesignPattern.Face.FacePattern
{
    public class AddOrderDetail
    {
        Context context = new Context();

        public void AddNewOrderDetails( OrderDetails orderDetails)
        {
            context.OrderDetails.Add(orderDetails);
            context.SaveChanges();
        } 
    }
}
