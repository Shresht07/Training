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