namespace Training {
   internal class Program {
      private static void Main (string[] args) {
         string[] wordList = File.ReadAllLines (@"C:\Users\baskaransh\Downloads\words.txt");
         char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
         Dictionary<string, int> validWords = FindValidWords (wordList, letters);
         var res = validWords.OrderByDescending (pair => pair.Value).ThenBy (pair => pair.Key).ToList ();
         Console.WriteLine ("Word\t\tScore");
         int total = validWords.Sum (x => x.Value);
         foreach (var result in res) if (IsPangram (result.Key, letters)) {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine ($"{result.Key}\t{result.Value}");
               Console.ResetColor ();
            } else if (result.Value == 9) Console.WriteLine ($"{result.Key}\t{result.Value}");
            else Console.WriteLine ($"{result.Key}\t\t{result.Value}");
         Console.WriteLine ($"Total\t\t{total}");

         static bool IsWordValid (string word, char[] letters) {
            foreach (char letter in word)
               if (!letters.Contains (letter)) return false;
            return true;
         }

         static Dictionary<string, int> FindValidWords (string[] wordList, char[] letters) {
            var validWords = new Dictionary<string, int> ();
            foreach (string word in wordList) 
               if (word.Length >= 4 && word.Contains (letters[0]) && IsWordValid (word, letters)) {
                  int score = IsPangram (word, letters) ? word.Length + 7 : word.Length;
                  validWords[word] = score;
               }
            return validWords;
         }

         static bool IsPangram (string word, char[] letters) {
            foreach (char letter in letters)
               if (!word.Contains (letter)) return false;
            return true;
         }
      }
   }
}
