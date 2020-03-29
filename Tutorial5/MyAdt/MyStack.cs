namespace MyAdt
{
    public class MyStack : IStack
    {
        private int[] data;
        private int index;

        public MyStack(int size)
        {
            this.data = new int[size];
            this.index = -1;
        }

        public int?[] Elements {
            get
            {
                int?[] elements = new int?[this.data.Length];
                for(int i = 0; i <= this.index; i++)
                {
                    elements[i] = this.data[i];
                }
                return elements;
            }
        }

        public void Clear()
        {
            this.index = -1;
        }

        public bool IsEmpty()
        {
            return this.index == -1;
        }

        public bool IsFull()
        {
            return this.index == this.data.Length - 1;
        }

        public int Pop()
        {
            if (this.IsEmpty())
            {
                throw new System.Exception("stack is empty!");
            }
            int tmp = this.data[this.index];
            this.index--;
            return tmp;
        }

        public void Push(int number)
        {
            if (this.IsFull())
            {
                throw new System.Exception("stack is full!");
            }
            this.index++;
            this.data[this.index] = number;
        }

        public int Top()
        {
            return this.data[this.index];
        }
    }
}
