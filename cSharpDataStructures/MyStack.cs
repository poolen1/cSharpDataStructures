
namespace cSharpDataStructures
{
    internal class MyStack<T>
    {
        private List<T> _stack;

        public List<T> Stack { get => _stack; set => _stack = value; }

        public MyStack(int size)
        {
            Stack = new List<T>(size);
        }

        public T ReadStack()
        {
            return Stack[0];
        }

        public T Pop() 
        { 
            return Stack[Stack.Count - 1];
        }

        public void Push(T item)
        {
            Stack[Stack.Count - 1] = item;
        }
    }
}
