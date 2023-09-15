Console.Write ("Enter the number to be factorized: ");
int inputNumber = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Factorial of the input number is {Factorial (inputNumber)}");
static long Factorial (int inputNumber) {
   if (inputNumber == 0)
      return 1;
   else
      return inputNumber * Factorial (inputNumber - 1);
}