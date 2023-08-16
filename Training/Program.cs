//Fibonacci series calculator
int number;
while (true) {
   Console.Write ("Enter f(n): ");                                                     //Checks whether the given input is a valid integer or not
   if (int.TryParse (Console.ReadLine (), out number) && number >= 0)
      break;
   else
      Console.WriteLine ("Invalid Input :(");
}
Console.Write ("Fibonacci series: ");                                                  
for (int i = 0; i < number; i++) {                                                    //initialized i as 0 and if i is lesser than the given number and incrementing by 1
   Console.Write ($"{FibonacciSeq (i)},");                                            //Prints the fibonacci series 
}
int FibonacciSeq (int number) {                                                       //This function calculates the fibonacci series 
   if (number <= 1)                                                                   //If number less than 1, returns the number
      return number;
   else
      return FibonacciSeq (number - 1) + FibonacciSeq (number - 2);                  //else returns fiboonacci series using formula fn = f(n-1) + f(n-2)
}
