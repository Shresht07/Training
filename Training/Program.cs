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
         Dictionary<string, int> validWords = FindValidWords (wordList, letters);
         var res = validWords.OrderByDescending (pair => pair.Value).ThenBy (pair => pair.Key).ToList ();
         Console.WriteLine ("Word\t\tScore");
         int total = validWords.Sum (x => x.Value);
         foreach (var result in res) 
            if (IsPangram (result.Key, letters)) {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine ($"{result.Key}\t{result.Value}");
               Console.ResetColor ();
            } 
         else if (result.Value == 9) Console.WriteLine ($"{result.Key}\t{result.Value}");
            else Console.WriteLine ($"{result.Key}\t\t{result.Value}");
         Console.WriteLine ($"Total\t\t{total}");
         /// <summary>This method checks if the iterated word is valid or not</summary>
         /// <param name="word">word from Word list</param>
         /// <param name="letters">Characters list</param>
         /// <returns>Word is valid or not</returns>
         static bool IsWordValid (string word, char[] letters) {
            foreach (char letter in word)
               if (!letters.Contains (letter)) return false;
            return true;
         }
         /// <summary>This method checks if the iterated word is valid or not</summary>
         /// <param name="wordList">Word list</param>
         /// <param name="letters">Characters list</param>
         /// <returns>Valid words addition to a resultant dictionary</returns>
         static Dictionary<string, int> FindValidWords (string[] wordList, char[] letters) {
            var validWords = new Dictionary<string, int> ();
            foreach (string word in wordList) 
               if (word.Length >= 4 && word.Contains (letters[0]) && IsWordValid (word, letters)) {
                  int score = IsPangram (word, letters) ? word.Length + 7 : word.Length;
                  validWords[word] = score;
               }
            return validWords;
         }
         /// <summary>This method checks if the iterated word is pangram or not</summary>
         /// <param name="word">word from Word list</param>
         /// <param name="letters">Characters list</param>
         /// <returns>Word is pangram or not</returns>
         static bool IsPangram (string word, char[] letters) {
            foreach (char letter in letters)
               if (!word.Contains (letter)) return false;
            return true;
         }
      }
      #endregion
   }
   #endregion
}
