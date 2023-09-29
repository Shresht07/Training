// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.                                               
// ---------------------------------------------------------------------------      
// Program.cs                                                                    
// <TODO: This file contains the code which returns the winner of a voting contest between the chars present in the input by the user>
// ---------------------------------------------------------------------------------------
using System.Text.RegularExpressions;
namespace Training {
   #region TestProgram --------------------------------------------------------------------------
   /// <summary>Voting Contest</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Takes an string of contestents as input and returns the winner as output</summary>
      /// <param name="args">Arguments</param>
      private static void Main (string[] args) {
         Console.WriteLine ("Voting Contest\nThe input must not be an empty string");
         for (; ; ) {
            Console.Write ("Enter the contestents: ");
            string inputStr = Console.ReadLine ();
            if (inputStr == "~")
               break;
            else if (inputStr.Length == 1)
               Console.WriteLine ($"And the winner is: {inputStr.ToUpper ()} with {inputStr.Length} vote\nPress '~' and 'enter' to Quit");
            else if (Regex.IsMatch (inputStr, "^[a-zA-Z]+$")) {
               (string, int) winner = VotingContest (inputStr);
               Console.WriteLine ($"And the winner is: {winner.Item1.First ()} with {winner.Item2} votes");
               Console.WriteLine ("Press '~' and 'enter' to Quit");
               continue;
            } else
               Console.WriteLine ("Enter a valid string");
         }
      }
      /// <summary>Takes input of the user as contestents and returns the winner and the count of votes he won with</summary>
      /// <param name="inputStr">User input</param>
      /// <returns>Winner of the voting contest</returns>
      static (string, int) VotingContest (string inputStr) {
         char[] contestents = inputStr.ToUpper ().ToCharArray ();
         Array.Sort (contestents);
         string result = "";
         for (int i = 0; i < contestents.Length - 1; i++) result += contestents[i] == contestents[i + 1] ? contestents[i] : contestents[i] + ",";
         return (result.Split (',').OrderByDescending (g => g.Length).First (), result.Split (',').OrderByDescending (g => g.Length).First ().Length);
      }
      #endregion
   }
   #endregion
}
