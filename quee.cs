namespace Linklistapplication
{
    public class Piority_quee
    {
        private int[] queearray;
        public int fist = 0, last = 0, count = 0, num = 0;
        public Piority_quee(int size)
        {
            queearray = new int[size];
        }
        public void enquee(int i)
        {
            num = Shiftoinsert(i);
            if (num != -1)
            {
                queearray[num] = i;
                count++;
            }
        }
        public int dequee()
        {
            if (!empty())
            {
                var item = queearray[--count];
                queearray[count] = 0;
                return item;
            }
            Console.WriteLine("quee is empty, last one ");
            return 0;
        }
        public bool empty()
        {
            return count == 0;
        }
        public int Shiftoinsert(int i)
        {
            if (isfull())
            {
                Console.WriteLine("quee is full");
                return -1;
            }
            num = count - 1;
            while (num >= 0)
            {
                if (i < queearray[num])
                {
                    queearray[num + 1] = queearray[num];
                    num--;
                }
                else break;
            }
            return num + 1;
        }
        public bool isfull()
        {
            return count == queearray.Length;
        }
    }
    public class QUEEusingtwostack
    {
        public Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        public void enquee(int val)
        {
            stack1.Push(val);
        }
        public int dequee()
        {
            if (empty())
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
            }
            return stack2.Pop();
        }
        public bool empty()
        {
            return stack1.Count <= 0 && stack2.Count <= 0;
        }
        public int Peek()
        {
            if (empty())
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
            }
            return stack2.Peek();
        }
        public class Quee_array
        {
            int[] quee;
            private int fist = 0, last = 0, count = 0, num = 0;
            public Quee_array(int capacity)
            {
                quee = new int[capacity];
            }
            public void enquee(int num)
            {
                if (count != quee.Length)
                {
                    quee[last] = num;
                    last = (last + 1) % quee.Length;
                    count++;
                }
                else
                {
                    throw new Exception("quee is full ");
                }
            }
            public int dequee()
            {
                int item;
                if (count > 0)
                {
                    item = quee[fist];
                    quee[fist] = 0;
                    fist = (fist + 1) % quee.Length;
                    count--;
                    return item;
                }
                Console.WriteLine("empty quee");
                return -1;
            }
            public bool empty()
            {
                return last == 0;
            }
            public bool full()
            {
                return fist == last;
            }
            public int size()
            {
                return quee.Length;
            }
            public int Peek()
            {
                return quee[fist];
            }
            public void display()
            {
                for (int i = 0; i < quee.Length; i++)
                {
                    Console.WriteLine(quee[i]);
                }
            }
            public void reverse_specific(int i)
            {
                int temp;
                for (int j = 0; j <= i; j++)
                {
                    temp = quee[j];
                    quee[j] = quee[i];
                    quee[i] = temp;
                    i--;
                }
            }
        }
        public class Linklist_Quee
        {
            private class Node
            {
                public int value;
                public Node next;
                public Node()
                {
                    value = 0;
                    next = null!;
                }
            }
            private Node? Head;
            private Node? tail;
            int size = 0;
            public Linklist_Quee()
            {
                Head = null;
                tail = null;
            }
            public void enquee(int val)
            {
                Node? node = new Node();
                node.value = val;
                if (Head == null)
                {
                    Head = tail = node;
                }
                else
                {
                    tail!.next = node;
                    tail = node;
                }
                size++;
            }
            public int dequee()
            {
                if (Head != null)
                {
                    var node = Head!;
                    Head = Head!.next;
                    size--;
                    return node.value;
                }
                Console.WriteLine("linklist quee null");
                return -1;
            }
            public int peek()
            {
                if (Head != null)
                {
                    return Head.value;
                }
                Console.WriteLine("quee is null");
                return -1;
            }
            public bool empty()
            {
                return Head == tail;
            }
            public int Size()
            {
                return size;
            }
        }
        public class Program
        {
            static void Main()
            {
                Linklist_Quee linklist_Quee = new Linklist_Quee();
                linklist_Quee.enquee(1);
                linklist_Quee.enquee(2);
                linklist_Quee.enquee(3);
                linklist_Quee.enquee(4);
                linklist_Quee.enquee(5);
                Console.WriteLine(linklist_Quee.dequee());
                Console.WriteLine(linklist_Quee.dequee());
                Console.WriteLine(linklist_Quee.dequee());
                Console.WriteLine(linklist_Quee.dequee());
                Console.WriteLine(linklist_Quee.dequee());
                Console.WriteLine(linklist_Quee.dequee());
            }
            static void reverse(Queue<int> num, int size)
            {
                Stack<int> stack = new Stack<int>();
                for (int count = 0; count < size; count++)
                {
                    stack.Push(num.Dequeue());
                }
                for (int count = 0; count < size; count++)
                {
                    num.Enqueue(stack.Pop());
                }
            }
        }
    }
}