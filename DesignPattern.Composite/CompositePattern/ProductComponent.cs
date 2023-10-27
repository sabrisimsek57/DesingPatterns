namespace DesignPattern.Composite.CompositePattern
{
    public class ProductComponent : IComponent
    {
        public ProductComponent(int ıD, string name)
        {
            ID = ıD;
            Name = name;
        }

        public int ID { get ; set ; }
        public string Name { get ; set ; }

        public string Display()
        {
           return $"<li class='list-group-item'>{Name}";
        }

        public int TotalCount()
        {
            return 1;
        }
    }
}
