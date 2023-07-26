int n, number, guesses;
bool Game=true;
string play_again;
while (Game) {
   number = 0;
   n = new Random ().Next (1, 100 + 1);
   guesses = 0;
   while (number != n) {
      Console.Write ("Enter a number from 1 to 100: ");
      number = int.Parse (Console.ReadLine ());
      if (number > n)
         Console.WriteLine ("Your guess is too high,try again");
      else if (number < n)
         Console.WriteLine ("Your guess is too low,try again");
      guesses++;
      if (guesses > 6) {
         Console.WriteLine ("Sorry, game over :( "); break;
      }
   }
   if (number == n)
      Console.WriteLine ("Well done, your guess is correct!");
   Console.WriteLine ("Would You like to play again ? (Yes/No)");
   play_again = Console.ReadLine ();
   if (play_again == "Yes" || play_again == "yes")
      Game = true;
   else {
      Console.WriteLine ("Thank you for playing the game !!"); break;
   }
}  
