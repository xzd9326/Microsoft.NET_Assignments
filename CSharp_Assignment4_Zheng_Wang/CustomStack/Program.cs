using CustomStack;

MyStack<int> stack1 = new MyStack<int>();
stack1.Push(1);
stack1.Push(2);
Console.WriteLine(stack1.Pop());
Console.WriteLine(stack1.Pop());
stack1.Push(3);
stack1.Push(4);
stack1.Push(5);
Console.WriteLine("The stack now has " + stack1.Count() + " elements.");


MyStack<string> stack2 = new MyStack<string>(2);
stack2.Push("Alice");
stack2.Push("Bob");
Console.WriteLine("The stack now has " + stack2.Count() + " elements.");
Console.WriteLine(stack2.Pop());
stack2.Push("Charlie");
stack2.Push("Dylan");
stack2.Push("Eric");
Console.WriteLine(stack2.Pop());
Console.WriteLine(stack2.Pop());
Console.WriteLine(stack2.Pop());
Console.WriteLine(stack2.Pop());
Console.WriteLine("The stack now has " + stack2.Count() + " elements.");