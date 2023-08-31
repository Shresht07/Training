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
   string result = "";                                                                         // Initialize a variable to store the longest abecedarian word found.
   foreach (string word in inWords) {                                                          // Iterate through each letter of each word in the array
      bool isAbe = true;
      for (int i = 0; i < word.Length - 1; i++) {                                              // Iterate through each letter of each word in the array
         if (word[i] > word[i + 1]) {                                                          // Checking whether the letters are greater than or not
            isAbe = false;                                                                     // If greater, then becomes false 
            break;
         }
      }
      if (isAbe && result.Length < word.Length) result = word;                                 // Temporary variable is updated
   }
   return (result.Length != 0) ? "Longest abecedarian word is " + result : "No abecedarian word in the given input";
}
Console.WriteLine (AbecedarianWord (inWords));                                                 // Returns the longest abecedarian wordand Printing the result
