

namespace MotoApp.Test
{
    public class MotoAppTests
    {

        [Test]
        public void StackDoublePushCountTest()
        {
            //arrange
            var stack = new BasicStack<double>();
            stack.Push(4.5);
            stack.Push(43);
            stack.Push(33.6);
           
            //act
            var result = stack.Count;

            //assert
            Assert.That(3, Is.EqualTo(result));
        }

        [Test]
        public void StackDoublePopCountTest()
        {
            //arrange
            var stack = new BasicStack<double>();
            stack.Push(4.5);
            stack.Push(43);
            stack.Push(33.6);
            stack.Pop();
            stack.Pop();

            //act
            var result = stack.Count;

            //assert
            Assert.That(1, Is.EqualTo(result));
        }

        [Test]
        public void StackDoubleSumTest()
        {
            //arrange
            var stack = new BasicStack<double>();
            stack.Push(4.5);
            stack.Push(4.5);
            stack.Push(11);


            //act
            double sum = 0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item = {item}");
                sum += item;
            }

            //assert
            Assert.That(20, Is.EqualTo(sum));
        }

        [Test]
        public void StackStringPushAndPopCountTest()
        {
            //arrange
            var stackString = new BasicStack<string>();
            stackString.Push("pierwszy");
            stackString.Push("drugi");
            stackString.Push("trzeci");
            stackString.Pop();

            //act
            var result = stackString.Count;

            //assert
            Assert.That(2, Is.EqualTo(result));
        }
    }
}