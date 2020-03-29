namespace MyAdt
{
    public interface IStack : IADT
    {
        void Push(int number);
        int Pop();
        int Top();
    }
}
