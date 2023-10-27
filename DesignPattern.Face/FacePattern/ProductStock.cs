using DesignPattern.Face.Dal;

namespace DesignPattern.Face.FacePattern
{
    public class ProductStock
    {

   Context context = new Context();

        public void StockDecrase(int id , int amount)
        {
            var values = context.products.Find(id);
            values.ProductStock -= amount;
            context.SaveChanges();
        }
    }
}
