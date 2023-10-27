namespace DesigmPattern.IteratorDesigmPattern.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutes = new List<VisitRoute>();

        public void addvisit(VisitRoute visitRoute) 
        { 
            visitRoutes.Add(visitRoute);
        }


        public int VisitRouteCount{get => visitRoutes.Count; }

        public Iteractor<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
