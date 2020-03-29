namespace MyAdt
{
    public interface IADT
    {
        bool IsEmpty();
        bool IsFull();
        void Clear();

        int?[] Elements { get; }
    }
}
