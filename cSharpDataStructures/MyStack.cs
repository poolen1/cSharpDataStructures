
namespace cSharpDataStructures
{
    internal class MyStack<T>
    {
        private List<T> _stack;

        public List<T> Stack { get => _stack; set => _stack = value; }

        public MyStack()
        {
            Stack = new List<T>();
        }

        public T ReadStack()
        {
            return Stack[Stack.Count-1];
        }

        public T Pop() 
        { 
            T popped = Stack[Stack.Count-1];
            Stack.RemoveAt(Stack.Count - 1);
            return popped;
        }

        public void Push(T item)
        {
            Stack.Add(item);
        }
    }
}
