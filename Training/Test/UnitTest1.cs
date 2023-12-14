using ClassLibrary;

namespace Test {
   [TestClass]
   public class UnitTest1 {
      CustomDouble customDouble = new ();

      [TestMethod]
      public void TestParse () {
         double NaN = double.NaN;
         Dictionary<string, double> inputs = new () {
            ["-12"] = -12, ["+12"] = 12, ["12"] = 12, ["12.3"] = 12.3, ["12.34"] = 12.34,
            ["12e3"] = 12000, ["12.34e3"] = 12340, ["12.34E-2"] = 0.1234,
            [" 12.34 "] = 12.34, ["0.12"] = 0.12, ["12.0"] = 12,
            ["12e0"] = 12, ["0e0"] = 0, ["12.0e0"] = 12, ["123.456"] = 123.456
         };

         Dictionary<string, double> NaNCases = new () {
            ["-+12"] = NaN, ["*12"] = NaN, ["12.-3"] = NaN, [".14"] = NaN, ["12."] = NaN,
            ["12~"] = NaN, ["a12"] = NaN, ["12b"] = NaN, ["12..3"] = NaN, ["12.3e"] = NaN,
            ["12.3e-+"] = NaN, ["12.3e-+3"] = NaN, ["12.34e5."] = NaN, [".e3"] = NaN,
            ["e4"] = NaN, ["12e"] = NaN, ["+e3"] = NaN
         };

         foreach (var input in inputs) {
            double val = customDouble.Parse (input.Key);
            Assert.AreEqual (Math.Abs (input.Value), Math.Abs (val));
         }

         foreach (var cases in NaNCases) {
            double results = customDouble.Parse (cases.Key);
            Assert.AreEqual (Math.Abs (cases.Value), Math.Abs (results));
         }
      }
   }
}