// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.                                               
// ---------------------------------------------------------------------------      
// Program.cs                                                                    
// <TODO: Define what this file going to contains in terms of functionalities.(min 1:max 4 lines).
// e.g: Class program prints the text 'Hello World' in the console.
// Likewise, if the class has more definitions of methods, then just explain the functionalities in simple words>
// ---------------------------------------------------------------------------------------
using System.Text.RegularExpressions;
namespace Training {
   #region TestProgram --------------------------------------------------------------------------
   /// <summary>Voting Contest</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Takes an string of contestents as input and returns the winnervas output</summary>
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
               string winner = VotingContest (ref inputStr);
               Console.WriteLine ($"And the winner is: {winner.FirstOrDefault ()} with {winner.Length} votes");
               Console.WriteLine ("Press '~' and 'enter' to Quit");
               continue;
            } else
               Console.WriteLine ("Enter a valid string");
         }
      }
      /// <summary></summary>
      /// <param name="str">User input</param>
      /// <returns>Winner of the voting contest</returns>
      static string VotingContest (ref string str) {
         char[] contestents = str.ToUpper ().ToCharArray ();
         Array.Sort (contestents);
         string result = "";
         for (int i = 0; i < contestents.Length - 1; i++) result += contestents[i] == contestents[i + 1] ? contestents[i] : contestents[i] + ",";
         return result.Split (',').OrderByDescending (g => g.Length).FirstOrDefault ();
      }
      #endregion
   }
   #endregion
}