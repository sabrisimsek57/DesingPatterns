using DesignPattern.Face.Dal;

namespace DesignPattern.Face.FacePattern
{
    public class AddOrder
    {
        Context context = new Context();    
        public void AddNewOrder( Order order )
        {
            order.OrderDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            context.Orders.Add(order );
            context.SaveChanges();
        }
    }
}
