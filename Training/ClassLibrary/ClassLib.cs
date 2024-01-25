namespace ClassLibrary {
   public class TDoubleEndedQueue<T> {
      public TDoubleEndedQueue () {
         const int mDefaultCapacity = 4;
         mData = new T[mDefaultCapacity];
         mFrontIndex = -1;
         mRearIndex = -1;
         mSize = 0;
      }

      public void EnqueueFront (T item) {
         Check (IsFull);

         if (IsEmpty) {
            mFrontIndex = 0;
            mRearIndex = 0;
         } else if (mFrontIndex is 0) mFrontIndex = mData.Length - 1;
         else mFrontIndex--;

         mData[mFrontIndex] = item;
         mSize++;
      }

      public void EnqueueRear (T item) {
         Check (IsFull);

         if (IsEmpty) {
            mFrontIndex = 0;
            mRearIndex = 0;
         } else if (mRearIndex == mData.Length - 1) mRearIndex = 0;
         else mRearIndex++;

         mData[mRearIndex] = item;
         mSize++;
      }

      public T DequeueFront () {
         Check (IsEmpty);

         T removedItem = mData[mFrontIndex];
         if (mFrontIndex == mRearIndex) {
            mFrontIndex = -1;
            mRearIndex = -1;
         } else if (mFrontIndex == mData.Length - 1) mFrontIndex = 0;
         else mFrontIndex++;

         mSize--;
         return removedItem;
      }

      public T DequeueRear () {
         Check (IsEmpty);

         T removedItem = mData[mRearIndex];
         if (mFrontIndex == mRearIndex) {
            mFrontIndex = -1;
            mRearIndex = -1;
         } else if (mRearIndex is 0) mRearIndex = mData.Length - 1;
         else mRearIndex--;

         mSize--;
         return removedItem;
      }

      public T PeekFront () {
         Check (IsEmpty);
         return mData[mFrontIndex];
      }

      public T PeekRear () {
         Check (IsEmpty);
         return mData[mRearIndex];
      }

      public int Count => mSize;

      public bool IsEmpty => mSize is 0;

      private bool IsFull => mSize == mData.Length;

      private void Resize () {
         int newCapacity = mData.Length * 2;
         T[] newArray = new T[newCapacity];

         int index = 0;
         while (index < mSize) {
            newArray[index] = mData[mFrontIndex];
            index++;
            mFrontIndex = (mFrontIndex + 1) % mData.Length;
         }

         mFrontIndex = 0;
         mRearIndex = mSize - 1;
         mData = newArray;
      }

      void Check (bool condition) {
         if (condition == IsEmpty && IsEmpty) throw new InvalidOperationException ("Queue is empty.");
         if (condition == IsFull && IsFull) Resize ();
      }

      private T[] mData;
      private int mFrontIndex;
      private int mRearIndex;
      private int mSize;
   }
}