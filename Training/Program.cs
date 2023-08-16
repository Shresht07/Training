//Palindrome checker
Console.Write ("Enter a word: ");                                                            //gets the input from user
var word = Console.ReadLine ();                                                              
string WordReverse (string word) {                                                          //This function reverses the words 
   string wordRev = "";
   for(int i = word.Length-1; i >=0;i--) {
      wordRev += word[i];                                                                   //Adds the words in reverse order in the wordRev string
   }
   return wordRev;
}
if (word == WordReverse (word))                                                             //If the input ford is equal to the reverse of the word
   Console.WriteLine ($"{WordReverse (word)} is a palindrome of {word}");                   //the it is a palindrome
else
   Console.WriteLine ($"{WordReverse (word)} is not a palindrome of {word}");               //Else it is not a palindrome
