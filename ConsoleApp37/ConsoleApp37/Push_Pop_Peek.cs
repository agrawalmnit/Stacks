using System;
using System.Collections;
public class Push_Pop_Peek
{
    public static void Main(string[] args)
    {
        Stack myStack = new Stack();
        myStack.Push("The");
        myStack.Push("quick");
        myStack.Push("brown");
        myStack.Push("Fox");

        Console.WriteLine("Stack values");
        PrintValues(myStack, '\t');

        Console.WriteLine("(Pop)\t\t{0}", myStack.Pop());

        Console.WriteLine("stack values");
        PrintValues(myStack, '\t');

        Console.WriteLine("(Peek)\t\t{0}", myStack.Peek());

        Console.WriteLine("stack values");
        PrintValues(myStack, '\t');
    }

    public static void PrintValues(Stack myCollection, char separator)
    {
        foreach(Object obj in myCollection) 
            Console.WriteLine("{0}{1}", separator, obj);
        Console.WriteLine();
   }
}