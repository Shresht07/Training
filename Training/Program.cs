// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.                                               
// ---------------------------------------------------------------------------      
// Program.cs                                                                    
// <TODO: Displays the individual digits of a given number, which should also handle decimal digits.
// For example, 355.56 is the input number, output = integral part: 3 5 5; factorial part: 5 6. >
// ---------------------------------------------------------------------------------------
internal class Program {
   /// <summary>Display the individual digits of a given number</summary>
   /// <param name="args">arguments</param>
   private static void Main (string[] args) {
      for (; ; ) {
         Console.Write ("Enter a decimal number: ");
         if (decimal.TryParse (Console.ReadLine (), out decimal inputNum) && inputNum >= 0) {
            int integralRes = (int)Math.Floor (inputNum);
            decimal fractionalRes = inputNum - Math.Floor (inputNum);
            var integralPart = string.Join (" ", integralRes.ToString ().ToCharArray ());
            Console.WriteLine ($"Integral part: {integralPart}");
            if (fractionalRes > 0) {
               var fractionalPart = string.Join (" ", fractionalRes.ToString ().Remove (0, 2).ToCharArray ());
               Console.WriteLine ($"Fractional part: {fractionalPart}");
            } else
               Console.WriteLine ("Fractional part: 0");
            break;
         } else
            Console.WriteLine ("Enter a valid decimal number");
      }
   }
}
