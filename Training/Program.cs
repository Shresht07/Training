Console.Write ("Enter an integer: ");
int inputNumber = int.Parse (Console.ReadLine ());
static int ArmstrongNumber (int inputNumber) {
   List<int> digits = new ();
   int result = 0;
   if (inputNumber == 0)
      return 0;
   while (inputNumber > 0) {
      digits.Add (inputNumber % 10);
      inputNumber /= 10;
   }
   foreach (int digit in digits) {
      result += (int)Math.Pow (digit, digits.Count);
   }
   return result;
}
Console.WriteLine (ArmstrongNumber (inputNumber) == inputNumber ? "Its an Armstrong number" : "Its not an Armstrong number");
