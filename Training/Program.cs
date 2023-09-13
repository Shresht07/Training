//Console.Write ("Enter an integer: ");
//int inputNumber = int.Parse (Console.ReadLine ());
//static int ArmstrongNumber (int inputNumber) {
//   List<int> digits = new ();
//   int result = 0;
//   if (inputNumber == 0)
//      return 0;
//   while (inputNumber > 0) {
//      digits.Add (inputNumber % 10);
//      inputNumber /= 10;
//   }
//   foreach (int digit in digits) {
//      result += (int)Math.Pow (digit, digits.Count);
//   }
//   return result;
//}
//Console.WriteLine (ArmstrongNumber (inputNumber) == inputNumber ? "Its an Armstrong number" : "Its not an Armstrong number");



Console.WriteLine ("Enter an integer: ");
int inputNumber = int.Parse (Console.ReadLine ());

if (IsArmstrongNumber (inputNumber)) {
   Console.WriteLine ($"{inputNumber} is an Armstrong number.");
} else {
   Console.WriteLine ($"{inputNumber} is not an Armstrong number.");
}


static bool IsArmstrongNumber (int inputNumber) {
   int originalNumber = inputNumber;
   int result = 0;
   List<int> digits = new List<int> ();

   // Store the digits of the inputNumber in the 'digits' list
   while (inputNumber > 0) {
      int digit = inputNumber % 10;
      digits.Add (digit);
      inputNumber /= 10;
   }

   // Calculate the Armstrong number sum
   foreach (int digit in digits) {
      result += (int)Math.Pow (digit, digits.Count);
   }

   // Check if the result is equal to the original number
   return result == originalNumber;
}

