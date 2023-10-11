// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: Write a method, for a given money X along with price P of a chocolate and required wrappers W for a chocolate in exchange
// return the maximum number of chocolates C you can get along with any unused money X and wrappers W>
// ---------------------------------------------------------------------------------------
namespace Training {
   #region TestProgram --------------------------------------------------------------------------
   /// <summary>Chocolate wrappers</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>This method prints balance amount, maximum chocolates and balance wrappers</summary>
      /// <param name="args">arguments</param>
      private static void Main (string[] args) {
         int amount = GetInput ("Mention the amount of money you have: ", "Enter amount as an integer value");
         int price = GetInput ("Enter the price of a chocolate: ", "Enter the price as an integer value");
         int wrappers = GetInput ("Mention number of wrappers can be exchanged in order to get one chocolate: ", "Enter a valid integer as an input");
         (int x, int c, int w) = ChocolateWrappers (amount, price, wrappers);
         Console.Write ($"Maxmimum number of chocolates bought(C): {c}\nBalance amount(X): {x}\nBalance no.of wrappers(W): {w}");
      }

      /// <summary>Takes inputs from user and returns the maximum number of chocolates C one can get along with any unused money X and wrappers W </summary>
      /// <param name="input">User input</param>
      /// <returns>balance amount, maximum no.of chocolates and balance no.of wrappers</returns>
      static (int c, int x, int w) ChocolateWrappers (int amount, int price, int wrappers) {
         int maxChocolates = amount / price, balAmount = amount % price, balWrappers = maxChocolates;
         while (balWrappers >= wrappers) {
            balWrappers -= wrappers;
            balWrappers++;
            maxChocolates++;
         }
         return (balAmount, maxChocolates, balWrappers);
      }

      /// <summary>Checks whether the input is valid or not</summary>
      /// <param name="input">User input</param>
      /// <returns>input integer</returns>
      static int GetInput (string questions, string warningMsg) {
         int input;
         for (; ; ) {
            Console.Write (questions);
            if (int.TryParse (Console.ReadLine (), out input) && input >= 0)
               break;
            else
               Console.WriteLine (warningMsg);
         }
         return input;
      }
      #endregion
   #endregion
   }
}