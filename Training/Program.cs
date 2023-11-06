// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// Program to Implement a Stack<T> class using arrays as the underlying data structure.
// The Stack<T> should start with an initial capacity of 4 and double its capacity when needed.
// class TStack<T> {
//    public void Push (T item) { }
//    public T Pop () { }
//    public T Peek () { }
//    public bool IsEmpty { get; }
// }
// ---------------------------------------------------------------------------------------

namespace Training {
   #region TStack<T> ---------------------------------------------------------------------
   class TStack<T> {
      #region Constructor -------------------------------------------
      /// <summary>Creates a new instance of TStack</summary>
      public TStack () => mVariables = new T[4];
      #endregion

      #region Properties --------------------------------------------
      public int Count => mSize;
      public int Capacity => mVariables.Length;

      /// <summary>Indicates whether the stack is empty</summary>
      public bool IsEmpty { get { return mVariables.Length == 0; } }
      #endregion

      #region Methods ----------------------------------------------------------------------
      /// <summary>Gets the top element from the stack and returns it</summary>
      public T Pop () {
         try {
            --mSize;
            return mVariables[mSize];
         } catch {
            throw new InvalidOperationException ("Could not pop due to empty stack");
         }
      }

      /// <summary>This method returns the top element of the stack without removing it</summary>
      /// <returns>Stack element at the top</returns>
      public T Peek () {
         try {
            return mVariables[mSize - 1];
         } catch {
            throw new InvalidOperationException ("Could not peek due to empty stack");
         }
      }

      /// <summary>An element is pushed to the top of the stack</summary>
      /// <param name="element">The element that needs to be pushed onto the stack</param>
      public void Push (T element) {
         if (Count == Capacity) Array.Resize (ref mVariables, Capacity * 2);
         mVariables[mSize++] = element;
      }
      #endregion

      #region Private Fields ---------------------------------------- 
      int mSize = 0;
      T[] mVariables;
      #endregion
   }
   #endregion
   internal class Program {
      static void Main (string[] args) {
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
