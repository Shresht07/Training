// Permutation of input word
string inWord;
for (; ; ) {
   Console.Write ("Enter input string: ");
   inWord = Console.ReadLine ();
   if (inWord.Any (char.IsDigit)) Console.WriteLine ("Enter valid input string");
   else {
      Console.WriteLine ($"Permutations of {inWord}: ");
      break;
   }
}
List<string> combinations = GeneratePermutations (inWord);

foreach (string permutation in combinations) {
   Console.WriteLine (permutation);
}
static List<string> GeneratePermutations (string inWord) {
   List<string> result = new ();
   if (inWord.Length == 1) {
      result.Add (inWord);
      return result;
   }
   for (int i = 0; i < inWord.Length; i++) {
      string currentWord = inWord[i].ToString();
      string remainingWord = inWord.Remove (i, 1);

      List<string> remainingPermutations = GeneratePermutations (remainingWord);

      foreach (string permutation in remainingPermutations) {
         result.Add (currentWord + permutation);
      }
   }
   return result;
}
