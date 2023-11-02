using MotoApp;

var stack = new BasicStack<double>();
stack.Push(4.5);
stack.Push(43);
stack.Push(33.6);

double sum = 0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item = {item}");
    sum += item;
}

Console.WriteLine($"Sume = {sum}");

Console.WriteLine("XXXXXXXXXXXX");
var stackString = new BasicStack<string>();
stackString.Push("pierwszy");
stackString.Push("drugi");
stackString.Push("trzeci");

while (stackString.Count > 0)
{
    var item = stackString.Pop();
    Console.WriteLine($"Item = {item}");
}

Console.WriteLine("KONIEC");