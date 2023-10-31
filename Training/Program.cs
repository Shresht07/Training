namespace Training {
   class TStack<T> {
      T[] mVariables;
      public TStack () => mVariables = new T[4];
      public int Count => mSize;
      public int Capacity => mVariables.Length;
      public void Push (T element) {
         if (Count == Capacity) Array.Resize (ref mVariables, Capacity * 2);
         mVariables[mSize++] = element;
      }

      public T Pop () {
         try {
            --mSize;
            return mVariables[mSize];
         } catch {
            throw new InvalidOperationException ("Could not pop due to empty stack");
         }
      }

      public T Peek () {
         try {
            return mVariables[mSize - 1];
         }
         catch {
            throw new InvalidOperationException ("Could not peek due to empty stack");
         }
      }

      public bool IsEmpty { get { return mVariables.Length == 0; } }
      int mSize = 0;
   }
   internal class Program {
      static void Main (string[] args) {
         TStack<string> stack = new ();
      }
   }
}
