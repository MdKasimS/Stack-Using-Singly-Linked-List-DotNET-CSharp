namespace DSA
{
    public class SLLStack
    {
        private static int count = 0;
        private SLLNode? head;
        private SLLNode? top;
        public SLLNode? Top { get => top; set => top = value; }
        public SLLNode? Head { get => head; set => head = value; }
        public static int Count { get => count; set => count = value; }
        public SLLStack()
        {
            Head = null;
            Top = null;
        }
        public void Push(int data)
        {
            if (Head == null)
            {
                Head = new SLLNode(data);
                Top = Head;
                ++Count;
            }
            else
            {
                Top.Next = new SLLNode(data);
                Top = Top.Next;
                ++Count;
            }
        }
        public void PrintStack()
        {
            if (Head != null)
            {
                int tempCount = Count;
                string indicator = "";
                SLLNode? iterator;
                for (int i = 0; i < Count; ++i)
                {
                    iterator = Head;
                    for (int j = tempCount; j > 1; --j)
                    {
                        iterator = iterator.Next;
                    }
                    if (tempCount == Count)
                    {
                        indicator = "<--- Top";
                    }

                    Console.WriteLine($"|{iterator.Data,6}| {indicator}");
                    Console.WriteLine("--------");
                    indicator = "";

                    --tempCount;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Stack Is Empty");
            }
        }
        public void Pop()
        {
            if (Count > 0)
            {
                SLLNode temp = Head;
                if (Count == 1)
                {
                    Head = null;
                    Top = null;
                    --Count;
                    return;
                }
                for (int i = 0; i < Count - 2; ++i)
                {
                    temp = temp.Next;
                }

                temp.Next = null;
                --Count;
                Top = temp;
            }
            else
            {
                Console.WriteLine("Stack Is Empty");
            }
        }
        public int Size()
        {
            return Count;
        }
        public string ShowTop()
        {
            if (Count > 0)
                return Top.Data.ToString();
            else
                return "[Stack Is Empty]";
        }
        public string IsEmpty()
        {
            if (Count == 0)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}