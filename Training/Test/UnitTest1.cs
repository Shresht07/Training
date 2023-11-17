// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Test.cs
// Program to test MyStack.
// ---------------------------------------------------------------------------------------

using ClassLibrary;

namespace Test {
   [TestClass]
   #region class ----------------------------------------------------------------------------------
   public class Test {
      TStack<int> customStack = new ();
      Stack<int> inBuiltStack = new ();

      #region Methods -----------------------------------------------
      [TestMethod]
      /// <summary>Test for capacity</summary>
      public void TestCapacity () {
         TestPush ();
         Assert.AreEqual (8, customStack.Capacity);
      }

      [TestMethod]
      /// <summary>Test for count</summary>
      public void TestCount () {
         TestPush ();
         Assert.AreEqual (inBuiltStack.Count, customStack.Count);
      }

      [TestMethod]
      /// <summary>Test for IsEmpty</summary>
      public void TestStackIsEmpty () => Assert.IsTrue (customStack.IsEmpty);

      [TestMethod]
      /// <summary>Test for peek</summary>
      public void TestPeek () {
         Assert.ThrowsException<InvalidOperationException> (() => customStack.Peek ());
         TestPush ();
         Assert.AreEqual (inBuiltStack.Peek (), customStack.Peek ());
      }

      [TestMethod]
      /// <summary>Test for pop</summary>
      public void TestPop () {
         Assert.ThrowsException<InvalidOperationException> (() => customStack.Pop ());
         TestPush ();
         Assert.AreEqual (inBuiltStack.Pop (), customStack.Pop ());
      }

      [TestMethod]
      public void TestPush () {
         for (int i = 1; i <= 5; i++) customStack.Push (i);
         for (int j = 1; j <= 5; j++) inBuiltStack.Push (j);
      }
      #endregion
   }
}
#endregion
