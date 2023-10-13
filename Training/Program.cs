// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: Using the same word list given in the Spelling Bee assignment,
// Build a frequency table with occurrence of all the letters.
// The output are list of a letters with its occurrence count in descending order.
// Display the first 7 letters to be used as the seed for the Spelling Bee program>
// ---------------------------------------------------------------------------------------

namespace Training {
   #region TestProgram --------------------------------------------------------------------------
   /// <summary>Frequency table with occurrence of all the letters</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>This method displays the first 7 letters to be used 
      /// as the seed for the Spelling Bee program in descending order</summary>
      /// <param name="args">arguments</param>
      private static void Main (string[] args) {
         string[] wordList = File.ReadAllLines (@"C:\etc\words.txt");
         Dictionary<char, int> result = new ();
         foreach (var word in wordList) {
            foreach (char ch in word) 
               result[ch] = result.TryGetValue (ch, out int value) ? ++value : 1;
         }
         Console.WriteLine ("First 7 letters to be used as the seed for the Spelling Bee program");
         foreach (var c in result.OrderByDescending (ch => ch.Value).Take (7))
            Console.WriteLine ($"{c.Key} = {c.Value}");
      }
      #endregion
   }
   #endregion
}
