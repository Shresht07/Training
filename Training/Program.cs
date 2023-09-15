using System.Numerics;

Console.Write ("Enter the number to be factorized: ");
int inputNumber = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Factorial of the input number is {Factorial (inputNumber)}");
static BigInteger Factorial (int inputNumber) {
   BigInteger result = inputNumber * Factorial (inputNumber - 1);
   if (inputNumber == 0)
      return 1;
   else
      return result;
}