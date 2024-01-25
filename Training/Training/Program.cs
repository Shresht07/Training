using ClassLibrary;
class Program {
   static void Main () {
      TDoubleEndedQueue<int> deque = new ();

      for (int i = 1; i <= 10; i++) deque.EnqueueFront (i);
      for (int i = 1; i <= 10; i++) deque.EnqueueRear (i * i);

      for (int i = 1; i < 10; i++) deque.DequeueFront ();
      deque.DequeueRear ();
      deque.DequeueRear ();
      deque.DequeueFront ();
      deque.EnqueueRear (43);
      deque.DequeueFront ();

      Console.WriteLine ("Front of the deque: " + deque.PeekFront ());
      Console.WriteLine ("Rear of the deque: " + deque.PeekRear ());

      Console.WriteLine ("Removed from the front: " + deque.DequeueFront ());
      Console.WriteLine ("Removed from the rear: " + deque.DequeueRear ());

      Console.WriteLine ("Front of the deque after removal: " + deque.PeekFront ());
      Console.WriteLine ("Rear of the deque after removal: " + deque.PeekRear ());

      Console.WriteLine ($"Is queue empty? => {deque.IsEmpty}");
   }
}
