//A Number guessing game code, where the user guesss a number and the computer finds the secret number
int lowLimit = 0, highLimit = 100, nGuesses = 0, newLimit = (lowLimit + highLimit) / 2;
Console.WriteLine ("Finding the guessed number :)");
do {
   //prompts the user to enter y or n wheather the guessed number is lesser than or not
   Console.WriteLine ($"Is the number lesser than {newLimit}: [Y/N]");
   switch (Console.ReadKey (true).Key) {
      case ConsoleKey.Y:
         highLimit = newLimit;
         break;
      case ConsoleKey.N:
         lowLimit = newLimit;
         break;
      default:
         Console.WriteLine ("Enter valid key :(");
         break;
   }
   // increments each and every tries made by the user
   nGuesses++;
   newLimit = (lowLimit + highLimit) / 2;
   Console.WriteLine ();
} while (nGuesses < 6);
//No.of guesses made by the computer, which must be 6 for numbers in range 1 to 100
Console.WriteLine ($"{newLimit} is the guessed number ;)"); // prints the guessed number
