using ClassLibrary;
namespace Test {
   [TestClass]
   public class UnitTest1 {
      TDoubleEndedQueue<int> mNumbers = new ();

      [TestMethod]
      public void TestEnqueueAtFront () {
         for (int i = 0; i < 4; i++) mNumbers.EnqueueFront (i + 1);
         for (int j = 0; j < 4; j++) Assert.AreEqual (j + 1, mNumbers.DequeueRear ());
      }

      [TestMethod]
      public void TestEnqueueAtRear () {
         for (int i = 0; i < 4; i++) mNumbers.EnqueueRear (i + 1);
         for (int j = 0; j < 4; j++) Assert.AreEqual (j + 1, mNumbers.DequeueFront ());
      }

      [TestMethod]
      public void TestRearDequeue () {
         for (int i = 0; i < 5; i++) {
            if ((i + 1) > 2) mNumbers.EnqueueFront (i + 1);
            else mNumbers.EnqueueRear (2 - i);
         }
         for (int j = 0; j < 5; j++) Assert.AreEqual (j + 1, mNumbers.DequeueRear ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.DequeueRear ());
      }

      [TestMethod]
      public void TestFrontDequeue () {
         for (int i = 0; i < 5; i++) {
            if ((i + 1) > 2) mNumbers.EnqueueFront (i + 1);
            else mNumbers.EnqueueRear (2 - i);
         }
         for (int j = 5; j > 0; j--) Assert.AreEqual (j, mNumbers.DequeueFront ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.DequeueFront ());
      }

      [TestMethod]
      public void TestForPeekFrontAndRear () {
         for (int i = 0; i < 5; i++) mNumbers.EnqueueFront (i);
         Assert.AreEqual (mNumbers.PeekFront (), mNumbers.Count - 1);
         for (int j = 5; j > 0; j--) mNumbers.EnqueueRear (j);
         Assert.AreEqual (mNumbers.PeekRear (), (mNumbers.Count / 4) - 1);
      }
   }
}