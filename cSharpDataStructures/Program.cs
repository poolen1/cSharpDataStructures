using cSharpDataStructures;

Console.WriteLine("===================================");
string testString = "abcde";
Console.WriteLine("Reverse string \"" + testString + "\" using stack: ");

MyStack<char> testStack = new MyStack<char>();
string reversed = "";

foreach (char c in testString)
{
    testStack.Push(c);
    Console.WriteLine(testStack.ReadStack());
}

foreach (char c in testString)
{
    reversed += testStack.Pop();
}

Console.WriteLine("Reversed string: " + reversed);

Console.WriteLine("===================================");
Console.Read();