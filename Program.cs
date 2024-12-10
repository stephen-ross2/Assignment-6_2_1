namespace Assignment_6_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(3); // Create a stack of size 3

            //Adds numbers to the stack until it is full. The 4th number generates a stack overflow message.
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            //Removes numbers from the stack until it is empty. The 4th removal generates a stack underflow message.
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

        }

        class Stack
        {
            public int[] stackArray;  // Array to store stack elements
            public int top;           // Index of the top element

           
            public Stack(int size)
            {
                stackArray = new int[size];
                top = -1; // Indicates an empty stack since valid arrays start at 0.
            }

            // Push Method to add an element to the stack
            public void Push(int value)
            {
                if (top == stackArray.Length - 1)
                {
                    Console.WriteLine("Stack Overflow" + value);
                }
                else
                {
                    stackArray[++top] = value;
                    Console.WriteLine(value + " pushed to stack.");
                }
            }

            // Pop Method to remove and return the top element
            public void Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack Underflow! Cannot pop.");
                }
                else
                {
                    Console.WriteLine(stackArray[top--] + " popped from stack.");
                }
            }
        }
    }
}