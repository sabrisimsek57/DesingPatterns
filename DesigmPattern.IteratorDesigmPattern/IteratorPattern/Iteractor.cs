namespace DesigmPattern.IteratorDesigmPattern.IteratorPattern
{
    public interface Iteractor<T>
    {
        T CurrentItem { get; }

        bool NextLocation();

    }
}
