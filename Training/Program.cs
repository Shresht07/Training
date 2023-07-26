namespace Assignment_1 {
   internal class Program {
      static void Main (string[] args) {
         int n, number, guesses;
         bool game = true;
         while (game) {
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
            }
            Console.WriteLine ("Well done, your guess is correct!");
            break;
         }
      }
      }

   }
