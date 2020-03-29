namespace MyAdt
{
    public class MyQueue : IQueue
    {
        private int[] data;
        private int head;
        private int tail;

        public MyQueue(int size)
        {
            this.data = new int[size];
            this.head = -1;
            this.tail = -1;
        }

        public int?[] Elements
        {
            get
            {
                int?[] elements = new int?[this.data.Length];
                for (int i = this.tail; i < this.head; i++)
                {
                    elements[i + 1] = this.data[i + 1];
                }
                return elements;
            }
        }

        public void Add(int number)
        {
            if (this.IsFull())
            {
                throw new System.Exception("queue is full!");
            }

            this.head++;
            this.data[this.head] = number;
        }

        public void Clear()
        {
            this.head = -1;
            this.tail = -1;
        }

        public int Get()
        {
            if (this.IsEmpty())
            {
                throw new System.Exception("queue is empty!");
            }

            this.tail++;
            return this.data[this.tail];
        }

        public bool IsEmpty()
        {
            return this.tail == this.head;
        }

        public bool IsFull()
        {
            return this.head == this.data.Length - 1;
        }
    }
}
