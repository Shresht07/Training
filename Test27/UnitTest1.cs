using Training;
namespace Test27 {
    [TestClass]
    public class UnitTest1 {
        TStack<int> stack = new ();
        [TestMethod]
        public void TestMethod1 () {
            Assert.IsTrue (stack.IsEmpty);
            Assert.ThrowsException<InvalidOperationException> (() => stack.Pop ());
            Assert.AreEqual (0, stack.Count);
            Assert.ThrowsException<InvalidOperationException> (() => stack.Peek ());
            stack.Push (1);
            stack.Push (2);
            stack.Push (3);
            stack.Push (4);
            stack.Push (5);
            Assert.AreEqual (stack.Peek (), 5);
            Assert.AreEqual(stack.Pop (), 5);
        }
    }
}