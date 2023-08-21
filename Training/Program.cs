//Fibonacci series calculator
int number, i = 0;
while (true) {
   Console.Write ("Enter f(n): ");                                                    //Checks whether the given input is a valid integer or not
   if (int.TryParse (Console.ReadLine (), out number) && number >= 0)
      break;
   else
      Console.WriteLine ("Enter a valid number");
}
Console.Write ("Fibonacci series: ");
do {                                                                                  //Initialized i as 0 and if i is lesser than the given number and incrementing by 1
   Console.Write ($"{FibonacciSeq (i)},"); i++;
} while (i < number-1);
Console.Write ($"{FibonacciSeq (number-1)}");                                         //Prints the fibonacci series
int FibonacciSeq (int number) {                                                       //This function calculates the fibonacci series 
   if (number <= 1)                                                                   //If number less than 1, returns the number
      return number;
   else
      return FibonacciSeq (number - 1) + FibonacciSeq (number - 2);                   //Else returns fiboonacci series using formula fn = f(n-1) + f(n-2)
}
