//Palindrome checker
Console.Write ("Enter a word: ");                                                            //gets the input from user
var word = Console.ReadLine ();                                                              
static string WordReverse (string word) {                                                          //This function reverses the words 
   string wordRev = "";
   for(int i = word.Length-1; i >=0;i--) {
      wordRev += word[i];                                                                   //Adds the words in reverse order in the wordRev string
   }
   return wordRev;
}
//If the input word is equal to the reverse of the word,then it is a palindrome,else it is not a palindrome
var result = (word == WordReverse (word)) ? ($"{WordReverse (word)} is a palindrome of {word}") : ($"{WordReverse (word)} is not a palindrome of {word}");
Console.WriteLine (result);