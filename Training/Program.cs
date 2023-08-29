// Abecedarian word detector
int nWords;
for (; ; ) {
   Console.Write ("Mention the no.of input words: ");
   if (int.TryParse (Console.ReadLine (), out nWords) && nWords >= 0)
      break;
   else
      Console.WriteLine ("Enter a valid number");
}
static string[] GetWordInput (int nWords) {
   string[] words = new string[nWords];
   for (int i = 1; i <= nWords; i++) {
      Console.Write ($"Enter word {i}: ");
      words[i - 1] = Console.ReadLine ();
   }
   return words;
}
string[] inWords = GetWordInput (nWords);
static string AbecedarianWord (string[] inWords) {
   string longestAbecedarianWord = "";
   foreach (string word in inWords) {
      char[] sortedChars = word.ToCharArray ();
      Array.Sort (sortedChars);
      string sortedWord = new (sortedChars);
      if (sortedWord == word && word.Length > longestAbecedarianWord.Length) {
         longestAbecedarianWord = word;
      }
   }
   return longestAbecedarianWord;
}
Console.WriteLine ("Longest abecedarian word is "+AbecedarianWord(inWords));