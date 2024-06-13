using System.Collections.Generic;

namespace cSharpDataStructures
{
    internal class Stack<T>(int size)
    {
        private List<T> _stack = new List<T>(size);

        public List<T> MyStack { get; set; }
    }
}
