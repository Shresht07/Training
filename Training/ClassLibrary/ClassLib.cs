// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// ClassLib.cs
// Program to Implement a Stack<T> class using arrays as the underlying data structure.
// The Stack<T> should start with an initial capacity of 4 and double its capacity when needed.
// class TStack<T> {
//    public void Push (T item) { }
//    public T Pop () { }
//    public T Peek () { }
//    public bool IsEmpty { get; }
// }
// ------------------------------------------------------------------------------------------------

namespace ClassLibrary {
   #region TStack<T> ------------------------------------------------------------------------------
   public class TStack<T> {
      #region Properties --------------------------------------------
      /// <summary>This property returns the current list capacity</summary>
      public int Capacity => mData.Length;

      /// <summary>This property returns the current list count</summary>
      public int Count => mSize;

      /// <summary>Indicates whether the stack is empty</summary>
      public bool IsEmpty => mSize == 0;
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>This method checks if the stack is empty 
      /// and throws exception</summary>
      public void Check () {
         if (mSize == 0)
            throw new InvalidOperationException ("Empty stack");
      }

      /// <summary>This method returns the top element of the stack
      /// without removing it</summary>
      /// <returns>Stack element at the top</returns>
      public T Peek () {
         Check ();
         return mData[mSize - 1];
      }

      /// <summary>Gets the top element from the stack and returns it</summary>
      public T Pop () {
         Check ();
         return mData[--mSize];
      }

      /// <summary>An element is pushed to the top of the stack</summary>
      /// <param name="element">The element that needs to be pushed
      /// onto the stack</param>
      public void Push (T element) {
         if (Count == Capacity) Array.Resize (ref mData, Capacity * 2);
         mData[mSize++] = element;
      }
      #endregion

      #region Private Fields ----------------------------------------
      T[] mData = new T[4];
      int mSize = 0;
      #endregion
   }
}
#endregion
