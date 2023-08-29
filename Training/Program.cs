// Isogram checker  
Console.Write ("Enter a string: ");                                       // Gets an input string 
string isostr = Console.ReadLine ();
static bool IsIsogram (string isostr) {                                   // A method which checks whether the input is isogram or not
   char[] result = isostr.ToCharArray ();                                 // Spliting the string into single elements 
   Array.Sort (result);                                                    // Sorting the elements in ascending order 
   for (int i = 0; i < isostr.Length - 1; i++) {
      if (result[i] == result[i + 1])                                     // Checking whether same letter is occured consecutively
         return false;                                                    // Returns false if there same letter is occured consecutively, Since we have arranged it in ascending order
   }
   return true;                                                           // Returns true, if no letter matches
}
// If the method returns true, then its an isogram, else not an isogram
Console.WriteLine (IsIsogram (isostr) ? "Its a isogram" : "Not an isogram");
