//A Number guessing game code, where the user guesss a number and the computer finds the secret number
int lowLimit = 1, highLimit = 128, power = 1, remainder = 0, divisor = 2, nGuesses = 0;
Console.WriteLine ($"Find the guessed number :). Think of a number from {lowLimit} to {highLimit}:");
do {                                                                                                          
   Console.WriteLine ($"Is the remainder {remainder}, when you divide the number by {divisor}: [Y/N]");      //prompts the user to enter y or n wheather the remainder is 0 or 1 if divisible by 2
   switch (Console.ReadKey (true).Key) {
      case ConsoleKey.Y:
         power++;                                                                                           //power is incremented for each and every valid reply 
         nGuesses++;                                                                                        //increments each and every tries made by the user
         break;
      case ConsoleKey.N:
         remainder = remainder + (divisor / 2);
         power++; nGuesses++;
         break;
      default:
         Console.WriteLine ("Enter valid key :(");
         break;
   }
   divisor = (int)(Math.Pow (2, power));
} while (nGuesses < 7);                                                                                    //No.of guesses made by the computer, which must be 7 for numbers in range 1 to 128
Console.WriteLine ($"{remainder} is the guessed number ;)");                                               //prints the guessed number
