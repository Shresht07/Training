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
   List<string> permutations = new ();
   if (inWord.Length == 1) {
      permutations.Add (inWord);
      return permutations;
   }
   for (int i = 0; i < inWord.Length; i++) {
      string currentWord = inWord[i].ToString();
      string remainingWord = inWord.Remove (i, 1);

      List<string> remainingPermutations = GeneratePermutations (remainingWord);

      foreach (string permutation in remainingPermutations) {
         permutations.Add (currentWord + permutation);
      }
   }
   return permutations;
}
