// #1 WPROWADZENIE - Po co nam parametry generyczne? Generyczny Stos.

using MotoApp;

//var stack = new BasicStack<double>();
var stack = new Stack<double>();

stack.Push(4.5);
stack.Push(43);
stack.Push(333.6);

//var stackString = new BasicStack<string>();
var stackString = new Stack<string>();

stackString.Push("company1");
stackString.Push("company2");
stackString.Push("company3");

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");

// II Siła generyczności w C#
// Wprowadzenie