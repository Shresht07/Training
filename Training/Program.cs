// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: //Write a program to help solve a New-York Times style Spelling Bee.
// The program can assume a word list is given as a text file, and that the daily choice of 7 letters is provided as an array of 7 chars>
// ---------------------------------------------------------------------------------------
namespace Training {
   #region TestProgram --------------------------------------------------------------------------
   /// <summary>SpellBee solver</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>This Method prints List of words which satisfies the conditions given below </summary>
      /// <param name="args">arguments</param>
      private static void Main (string[] args) {
         string[] wordList = File.ReadAllLines (@"C:\Users\baskaransh\Downloads\words.txt");
         char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
         Dictionary<string, int> validWords = GetValidWords (wordList, letters);
         var result = validWords.OrderByDescending (pair => pair.Value).ThenBy (pair => pair.Key).ToList ();
         int total = validWords.Sum (x => x.Value);
         foreach (var res in result)
            if (IsPangram (res.Key, letters)) {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine ($"{res.Value}. {res.Key}");
               Console.ResetColor ();
               }
            else Console.WriteLine ($" {res.Value}. {res.Key}");
         Console.WriteLine ($"----\n{total} total");
      }

      /// <summary>This method provides a dictionary of words which are valid</summary>
      /// <param name="wordList">Word list</param>
      /// <param name="letters">Characters list</param>
      /// <returns>Valid words addition to a resultant dictionary</returns>
      static Dictionary<string, int> GetValidWords (string[] wordList, char[] letters) {
         var validWords = new Dictionary<string, int> ();
         foreach (string word in wordList)
            if (word.Length >= 4 && word.Contains (letters[0]) && word.All (letters.Contains)) {
               int score = IsPangram (word, letters) ? word.Length + 7 : word.Length <= 4 ? 1 : word.Length;
               validWords[word] = score;
            }
         return validWords;
      }

      /// <summary>This method checks if the iterated word is pangram or not</summary>
      /// <param name="word">word from Word list</param>
      /// <param name="letters">Characters list</param>
      /// <returns>Word is pangram or not</returns>
      static bool IsPangram (string word, char[] letters) => letters.All (word.Contains);
   }
      #endregion
   #endregion
}
