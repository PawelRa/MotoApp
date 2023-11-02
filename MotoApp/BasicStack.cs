namespace MotoApp
{
    public class BasicStack<T>
    {
        private readonly T[] _items;

        private int _curentIndex = -1;

        public BasicStack() => _items = new T[10];

        public int Count => _curentIndex + 1;

        public void Push(T item) => _items[++_curentIndex] = item;

        public T Pop() => _items[_curentIndex--];
    }
}
