using System;

namespace DataStructures
{
    public class Stack<T>
    {
        private const int InitialSize = 8; // setting the size of the array 
        private Item<T>[] stack;
        private int Top = -1; // gonna point to the top of the stack 
        public int Count { get; private set; } = 0;// to see how many are on the stack 
// True or False ; does count equal the stack length
        private bool Full => Count == stack.Length; // Is there any room on the fixed array? 
        public bool Empty => Count == 0; // Is the stack empty?


        public void Push(T t)
        {
            if (Full) // if array is full then create another array with twice the capacity
                DoubleCapacity();

            var item = new Item<T>(t); 

            stack[++Top] = item;
            Count++;
        }

        public void Push(params T[] ts)
        {
            foreach(var t in ts)
            {
                Push(t);
            }
        }

        public T Pop()
        {
            if (Empty)
                throw new Exception("Stack is empty!");
            Item<T> item = stack[Top];
            stack[Top--] = null; // taking the popped slot and returning it to null. 
            Count--;
            return item.t;
        }

        public void Reset()
        {
            Top = -1;
            Count = 0;
            stack = new Item<T>[InitialSize];
    
        }

        private void DoubleCapacity()
        {
            int newCapacity = stack.Length * 2; // declare new var for stacklength 
            Item<T>[] newStack = new Item<T>[newCapacity]; // takes new array length and assigs it to created stack 
            for( var idx = 0; idx < stack.Length; idx++)
            {
                newStack[idx] = stack[idx]; // loads og stacks values into new stack
            }
            stack = newStack; // takes new stack and assigns it to old stack 
        }
        public Stack()
        {
            stack = new Item<T>[InitialSize];
        }

    }
}
