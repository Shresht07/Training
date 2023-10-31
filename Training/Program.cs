// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO:Implement a custom MyList<T> class using arrays as the underlying data structure.
// The MyList<T> should start with an initial capacity of 4 and double its capacity when needed.
// Throw exceptions when necessary>
// ---------------------------------------------------------------------------------------
namespace Training {
   #region MyList_Class ---------------------------------------------------------------------------
   /// <summary>A generic list with dynamic resizing capabilities</summary>
   /// <typeparam name="T">The type of elements in the list.</typeparam>
   public class MyList<T> {
      #region Constructor -------------------------------------------
      /// <summary>Initializes a new instance of the <see cref="MyList{T}"/> class</summary>
      public MyList () => mVariables = new T[4];
      #endregion

      #region Properties --------------------------------------------
      /// <summary>This property returns the current list count</summary>
      public int Count => mSize;

      /// <summary>This property returns the current list capacity</summary>
      public int Capacity => mVariables.Length;

      /// <summary>The element at the specified index is get or set</summary>
      /// <param name="index">Gets or sets the zero-based index of the element</param>
      /// <returns>The element at the specified index</returns>
      /// <exception cref="IndexOutOfRangeException">Thrown when the index is out of range [0, Count)</exception>
      public T this[int index] {
         get {
            if (index < 0 || index >= mSize) throw new IndexOutOfRangeException ("Index is out of range");
            return mVariables[index];
         }
         set {
            if (index < 0 || index >= mSize) throw new IndexOutOfRangeException ("Index is out of range");
            mVariables[index] = value;
         }
      }
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Adds an element to the end of the list</summary>
      /// <param name="element">The element to add to the list</param>
      public void Add (T element) {
         if (Count == Capacity) Array.Resize (ref mVariables, Capacity * 2);
         mVariables[mSize++] = element;
      }

      /// <summary>Removes the first occurrence of a specific element from the list</summary>
      /// <param name="element">The element to remove</param>
      /// <returns>True if the element was successfully removed</returns>
      public bool Remove (T element) {
         if (mVariables.Contains (element)) {
            mVariables = mVariables.Except (new T[] { element }).ToArray ();
            return true;
         } else throw new InvalidOperationException ("Item that is not found in the list");
      }

      /// <summary>Clears the entire list</summary>
      public void Clear () => mSize = 0;

      /// <summary>Insert elements at a specified index</summary>
      /// <param name="index"></param>
      /// <param name="element"></param>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public void Insert (int index, T element) {
         if (index < 0 || index >= mVariables.Length) throw new IndexOutOfRangeException ("Index is out of range");
         if (Count == Capacity) Array.Resize (ref mVariables, Capacity * 2);
         mVariables[mSize++] = element;
         for (int i = mSize - 1; i >= index; i--) mVariables[i + 1] = mVariables[i];
         mVariables[index] = element;
      }

      /// <summary>Removes the element at the specified index</summary>
      /// <param name="index"></param>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public void RemoveAt (int index) {
         if (index < 0 || index >= mVariables.Length) throw new IndexOutOfRangeException ("Index is out of range");
         for (int i = index; i < mVariables.Length - 1; i++)
            mVariables[i] = mVariables[i + 1];
         Array.Resize (ref mVariables, mVariables.Length - 1);
         mSize--;
      }
      #endregion

      #region Private Fields ------------------------------------------------
      T[] mVariables;
      int mSize = 0;
      #endregion
   }
   #endregion

   /// <summary>The Main method of the MyList class is demonstrated</summary>
   internal class Program {
      #region Methods -----------------------------------------------
      /// <summary>Entry Point of the program</summary>
      static void Main (string[] args) {
         MyList<int> list = new ();
         Console.WriteLine ($"Count before adding elements in the list: {list.Count}");
         Console.WriteLine ($"Capacity before adding elements: {list.Capacity}");
         list.Add (0);
         list.Add (1);
         list.Add (2);
         list.Add (4);
         list.Add (5);
         list.Add (6);
         PrintMyList (list);
         Console.WriteLine ($"Count after adding elements in the list: {list.Count}");
         Console.WriteLine ($"Capacity after adding elements: {list.Capacity}");
         list.RemoveAt (0);
         list.Insert (2, 3);
         PrintMyList (list);
         list.Clear ();
         Console.Write ("After clearing list, list count => ");
         list.Add (list.Count);
         Console.WriteLine (list[0]);

         /// <summary>Tests the custom built-in List class</summary>
         /// <param name="list"></param>
         static void PrintMyList (MyList<int> list) {
            Console.Write ("{");
            for (int i = 0; i < list.Count - 1; i++)
               Console.Write (list[i] + ",");
            Console.WriteLine (list[^1] + "}");
         }
      }
   }
   #endregion
}
