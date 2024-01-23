// ------------------------------------------------------------------------------------------------
// Training 
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// UnitTest1.cs
// Test for File name parser
// ------------------------------------------------------------------------------------------------
namespace Test {
   #region TestClass ------------------------------------------------
   /// <summary>Test class for UnitTest1</summary>
   [TestClass]
   public class UnitTest1 {
      Dictionary<string, bool> sTests = new Dictionary<string, bool>
        {
            {"Cz:\\abc\\def\\r.txt", false},
            {"C:\\abc\\def\\r.txt", true},
            {"C:\\Readme.txt", false},
            {"C:\\abc\\.bcf", false},
            {"C:\\abc\\bcf.", false},
            {"Readme.txt", false},
            {"C:\\abc\\def", false},
            {"C:\\abc.d", false},
            {"\\abcd\\Readme.txt", false},
            {" ", false},
            {"C:\\ab.c\\def\\r.txt", false},
            {"C:\\abc:d", false},
            {".\\abc", false},
            {".abc", false},
            {"abc", false},
            {"C:\\abc6\\def\\r.txt", false},
            {"C:\\abc\\def\\r.txt.txt", false},
            {"C:\\work\\r.txt", true}
        };

      #region Methods
      /// <summary> Test method for UnitTest1</summary>
      [TestMethod]
      public void TestFileNameParser () {
         foreach (var testCase in sTests) {
            bool testResult = FileNameParser.TryParseFileName (testCase.Key, out _);
            Assert.AreEqual (testResult, testCase.Value);
         }
      }
      #endregion
   }
   #endregion
}