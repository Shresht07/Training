// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Test.cs
// Program to test custom queue.
// ---------------------------------------------------------------------------------------

using Training;

namespace Test {
   [TestClass]
   #region class ----------------------------------------------------------------------------------
   public class Test {
      TQueue<int> customQueue = new ();
      Queue<int> inBuiltQueue = new ();

      #region Methods -----------------------------------------------
      [TestMethod]
      /// <summary>Test for capacity</summary>
      public void TestCapacity () {
         TestEnqueue ();
         Assert.AreEqual (8, customQueue.Capacity);
      }

      [TestMethod]
      /// <summary>Test for count</summary>
      public void TestCount () {
         TestEnqueue ();
         Assert.AreEqual (inBuiltQueue.Count, customQueue.Count);
      }

      [TestMethod]
      /// <summary>Test for IsEmpty</summary>
      public void TestStackIsEmpty () => Assert.IsTrue (customQueue.IsEmpty);

      [TestMethod]
      /// <summary>Test for dequeue</summary>
      public void TestDequeue () {
         Assert.ThrowsException<InvalidOperationException> (() => customQueue.Dequeue ());
         TestEnqueue ();
         Assert.AreEqual (inBuiltQueue.Dequeue (), customQueue.Dequeue ());
      }

      [TestMethod]
      /// <summary>Test for enqueue</summary>
      public void TestEnqueue () {
         for (int i = 1; i <= 5; i++) customQueue.Enqueue (i);
         for (int j = 1; j <= 5; j++) inBuiltQueue.Enqueue (j);
      }

      [TestMethod]
      /// <summary>Test for peek</summary>
      public void TestPeek () {
         Assert.ThrowsException<InvalidOperationException> (() => customQueue.Peek ());
         TestEnqueue ();
         Assert.AreEqual (inBuiltQueue.Peek (), customQueue.Peek ());
      }
      #endregion
   }
}
#endregion