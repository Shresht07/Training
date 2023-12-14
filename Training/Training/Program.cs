using ClassLibrary;

internal class Program {
   static void Main (string[] args) {
      CustomDouble customDouble = new ();
      string[] inputs = {"-12", "+12", "12", "-+12", "*12","12.3", "12.34", "12.-3", ".14",
   "12.", "12~", "a12", "12b", "12..3","12e3", "12.34e3", "12.34E-2", "12.3e",
   "12.3e-+", "12.3e-+3", "12.34e5.", ".e3","e4", "12e", " 12.34 ", "0.12",
   "12.0", "12e0", "0e0", "12.0e0", "+e3","123.456"};

      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine ("Input          Parsed value");

      foreach (string input in inputs) {
         double parsedValue = customDouble.Parse (input);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write ($"{input}");
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.WriteLine ($"\t\t {parsedValue}");
         Console.ResetColor ();
      }
   }
}