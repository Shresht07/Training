// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Test.cs
// Excutes the custom class Queue<t>.
// ---------------------------------------------------------------------------------------

using Training;

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
