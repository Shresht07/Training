// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// Program to use class MyStack<T>.
// ---------------------------------------------------------------------------------------

using ClassLibrary;

namespace Training {
   internal class Program {
      static void Main () {
         TStack<string> stack = new ();
         Console.WriteLine ($"Count before pushing elements in stack: {stack.Count}");
         Console.WriteLine ($"Capacity of stack: {stack.Capacity}");
         Console.WriteLine ("After pushing elements in stack;");
         stack.Push ("Java");
         stack.Push ("Python");
         stack.Push ("C");
         stack.Push ("C++");
         stack.Push ("C#");
         Console.WriteLine ($"Peeked element: {stack.Peek ()}");
         Console.WriteLine ($"Count after pushing elements in stack: {stack.Count}");
         Console.WriteLine ($"Popped element: {stack.Pop ()}");
         Console.WriteLine ($"Count after a popped element in stack: {stack.Count}");
         Console.WriteLine ($"Capacity of stack now: {stack.Capacity}");
         Console.WriteLine ($"Is stack empty => {stack.IsEmpty}");
      }
   }
}
