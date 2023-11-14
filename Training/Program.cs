// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// Program to Implement a TQueue<T> class using arrays as the underlying data structure.
// TQueue<T> should start with an initial capacity of 4 and double its capacity when needed.
// class TQueue<T> {
//    public void Enqueue (T a) { } 
//    public T Dequeue () { }
//    public T Peek () { }
//    public bool IsEmpty {get;}
//}
// ---------------------------------------------------------------------------------------

namespace Training {
   #region TQueue<T> ----------------------------------------------------------------------------
   public class TQueue<T> {
      #region Properties --------------------------------------------
      /// <summary>Obtains the queue's capacity</summary>
      public int Capacity => mData.Length;

      /// <summary>Obtains the quantity of elements in the queue</summary>
      public int Count => mCount;

      /// <summary>Finds out if the stack is empty</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Checks and throws an exception if queue is empty</summary>
      /// <exception cref="InvalidOperationException">Thrown when the queue is empty</exception>
      public void Check () {
         if (IsEmpty) throw new InvalidOperationException ("Empty queue");
      }

      /// <summary>Removes and puts the element back at the front of the queue</summary>
      /// <returns>The element that was removed from queue's starting index</returns>
      /// <exception cref="InvalidOperationException">Thrown when the queue is empty</exception>
      public T Dequeue () {
         Check ();
         T item = mData[mFrontIndex];
         mData[mFrontIndex] = default;
         mFrontIndex = (mFrontIndex + 1) % mData.Length;
         mCount--;
         return item;
      }

      /// <summary>Adds an element to the queue's end.</summary>
      /// <param name="element">The element to be added to the queue</param>
      public void Enqueue (T element) {
         if (mCount == mData.Length) ResizeArray ();
         mData[mLastIndex] = element;
         mLastIndex = (mLastIndex + 1) % mData.Length;
         mCount++;
      }

      /// <summary>Returns the element without removing it from the top of the queue</summary>
      /// <returns>The element at queue's starting index</returns>
      /// <exception cref="InvalidOperationException">Thrown when the queue is empty</exception>
      public T Peek () {
         Check ();
         return mData[mFrontIndex];
      }

      /// <summary>Resizes the queue according to the current queue size</summary>
      private void ResizeArray () {
         int newCapacity = mData.Length * 2;
         T[] newData = new T[newCapacity];
         for (int i = 0; i < mCount; i++) newData[i] = mData[(mFrontIndex + i) % mData.Length];
         mFrontIndex = 0;
         mLastIndex = mCount;
         mData = newData;
      }
      #endregion

      #region Private Fields-----------------------------------------
      private int mCount = 0;
      private T[] mData = new T[4];
      private int mFrontIndex = 0, mLastIndex = 0;
      #endregion
   }
   #endregion

   internal class Program {
      static void Main (string[] args) {
         TQueue<int> queue = new ();
         for (int i = 0; i <= 10; i++) queue.Enqueue (i);
         queue.Dequeue ();
         Console.WriteLine ("Peeked element after dequeue of first element: " + queue.Peek ());
         Console.WriteLine ("Queue capacity: " + queue.Capacity);
         Console.WriteLine ("Queue count: " + queue.Count);
         Console.WriteLine ("Is queue empty => " + queue.IsEmpty);
      }
   }
}
