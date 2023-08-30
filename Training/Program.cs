// Abecedarian word detector
int nWords;
for (; ; ) {                                                                                   // Start an infinite loop to get a valid number of input words.
   Console.Write ("Mention the no.of input words: ");                                          // Ask the user to input the number of words.
   if (int.TryParse (Console.ReadLine (), out nWords) && nWords >= 0)                          // Try to parse the input as an integer, and check if it's non-negative.
      break;                                                                                   // Exit the loop if a valid number is entered.
   else
      Console.WriteLine ("Enter a valid number");                                              // Prompt for a valid input.
}
static string[] GetWordInput (int nWords) {                                                    // Define a method to get input words as an array.
   string[] words = new string[nWords];                                                        // Create an array to hold the input words.
   for (int i = 1; i <= nWords; i++) {                                                         // Loop through each word and get user input.
      Console.Write ($"Enter word {i}: ");
      words[i - 1] = Console.ReadLine ();
   }
   return words;                                                                               // Return the array of input words.
}
string[] inWords = GetWordInput (nWords);                                                      // Call the GetWordInput method to get input words.
static string AbecedarianWord (string[] inWords) {                                             // A method to find the longest abecedarian word.
   string longestAbecedarianWord = "";                                                         // Initialize a variable to store the longest abecedarian word found.
   foreach (string word in inWords) {                                                          // Iterate through each word in the input array.
      char[] sortedChars = word.ToCharArray ();                                                // Convert the word to an array of characters and sort them.
      Array.Sort (sortedChars);
      string sortedWord = new string (sortedChars);
      if (sortedWord == word && word.Length > longestAbecedarianWord.Length) {                 // Check if the sorted word is equal to the original word and longer than the current longest abecedarian word.
         longestAbecedarianWord = word;                                                        // Update the longest abecedarian word.
      }
   }
   return longestAbecedarianWord;                                                              // Return the longest abecedarian word.
}
Console.WriteLine ("Longest abecedarian word is " + AbecedarianWord (inWords));                // Print the result by calling the AbecedarianWord method and displaying the longest abecedarian word
