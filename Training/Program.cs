using Training;

namespace Training {
   class MyList<T> {
      T[] mVariables;
      public MyList () => mVariables = new T[4];

      public int Count => mSize;

      public int Capacity => mVariables.Length;

      public T this[int index] { get { return mVariables[index]; } set { mVariables[index] = value; } }

      public void Add (T element) {
         if (Count == Capacity) Array.Resize (ref mVariables, Capacity * 2);
         mVariables[mSize++] = element;
      }

      public bool Remove (T element) {
         if (mVariables.Contains (element)) {
            mVariables.Except (new T[] { element }).ToArray ();
            return true;
         }
         if (!mVariables.Contains (element)) throw new InvalidOperationException ("Item that is not found in the list");
         return false;
      }

      public void Clear () => Array.Clear (mVariables, 0, mSize);

      public void Insert (int index, T element) {
         if (Count == Capacity) Array.Resize (ref mVariables, Capacity * 2);
         mVariables[mSize++] = element;
         for (int i = mSize - 1; i >= index; i--) mVariables[i + 1] = mVariables[i];
         mVariables[index] = element;
      }

      public void RemoveAt (int index) {
         if (index < 0 || index >= mVariables.Length) throw new IndexOutOfRangeException ("Index is out of range");
         for (int i = index; i < mVariables.Length - 1; i++)
            mVariables[i] = mVariables[i + 1];
         Array.Resize (ref mVariables, mVariables.Length - 1);
         mSize--;
      }
      int mSize = 0;
   }
}
internal class Program {
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
      list.Insert (3, 3);
      PrintMyList (list);
      list.Clear ();
      Console.Write ("After clearing list: ");
      PrintMyList (list);
      list.Remove (9);
      list.RemoveAt (10);

      static void PrintMyList (MyList<int> list) {
         Console.Write ("{");
         for (int i = 0; i < list.Count - 1; i++)
            Console.Write (list[i] + ",");
         Console.WriteLine (list[^1] + "}");
      }
   }
}
