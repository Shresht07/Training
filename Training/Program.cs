Console.Write ("Enter an integer: ");
int inputNumber = int.Parse (Console.ReadLine ());
Console.WriteLine (IsArmstrongNumber (inputNumber) ? "It's an Armstrong number" : "It's not an Armstrong number");

static bool IsArmstrongNumber (int inputNumber) {
   List<int> digits = new ();
   int tempNumber = inputNumber;
   int result = 0;
   if (inputNumber == 0)
      return true;
   while (tempNumber > 0) {
      digits.Add (tempNumber % 10);
      tempNumber /= 10;
   }
   foreach (int digit in digits) {
      result += (int)Math.Pow (digit, digits.Count);
   }
   return result == inputNumber;
}
