namespace MotoApp
{
    public class BasicStack
    {
        private readonly double[] _items;

        private int _curentIndex = -1;

        public BasicStack() => _items = new double[10];

        public int Count => _curentIndex + 1;

        public void Push(double item) => _items[++_curentIndex] = item;

        public double Pop() => _items[_curentIndex--];
    }
}
