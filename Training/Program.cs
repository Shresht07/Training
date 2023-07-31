// This code impliments anumber guessing game, where the computer guesses a random number, tends us to find it
int random_number, guessed_number = 0, nGuesses = 0;
bool IsGameOver = true;
random_number = new Random ().Next (1, 101);                                              //This line initializes a random number
while (IsGameOver) {                                                                      //This is where the game begins 
   Console.Write ("Guess a number from 1 to 100: ");                                      //Takes an input value from range 1 to 100
   bool typo = int.TryParse (Console.ReadLine (), out guessed_number);                     //checks whether the recieved integer is a string or not
   if (guessed_number == random_number) {                                                 //If the guessed number is equal to the computer's number, then it prints "Well done, the guess is correct" and then breaks
      Console.WriteLine ("Well done, your guess is correct!"); break;
   }
   if (guessed_number > random_number && typo)                                            //If less then prints "too low" and if high then prints "too high"
      Console.WriteLine ("Your guess is too high,try again");
   else if (guessed_number < random_number && typo)
      Console.WriteLine ("Your guess is too low,try again");
   nGuesses++;                                                                            //For each guesses, the number of guesses is incremented
   if (nGuesses > 6) {                                                                    //If the number guesses surpasses the limit of 7, then the game gets over and prints "Sorry, Game over :( " and then the code breaks
      Console.WriteLine ("Sorry, Game over :( "); break;
   } else if (!typo)                                                                      //Checks whether user enters a string or a integer which exceeds the range [1,100]
      Console.WriteLine ("Enter a valid integer within the given range :|");
   if (guessed_number > 102 || guessed_number < 0)
      Console.WriteLine ("Enter a valid integer within the given range...");              //Prints a message "Enter a valid integer within the given range..." if the user makes the above mentioned line's condition true and then code breaks
}
