string inputStr, inSplChar;
for (; ; ) {
   Console.Write ("Enter a string: ");
   inputStr = Console.ReadLine ();
   if (inputStr == "")
      Console.WriteLine ("Enter a valid string. Empty string is not allowed");
   else
      break;
}
for (; ; ) {
   Console.Write ("Mention the special character to be swapped: ");
   inSplChar = Console.ReadLine ();
   if (inSplChar == "")
      Console.WriteLine ("Enter a valid special character. Entering empty special character is not allowed");
   else
      break;
}
Console.Write ("Mention the order: ");
string order = Console.ReadLine ();
SortAndSwapSplChars (inputStr, inSplChar, order);

static void SortAndSwapSplChars (string inputStr, string inSplChar, string order = "") {
   char splChar = char.Parse (inSplChar);
   char[] inputCharArray = inputStr.ToCharArray ();
   List<char> tempList = inputCharArray.ToList ();
   if (inputStr.Contains (splChar)) {
      tempList.RemoveAll (ch => ch == splChar);
      tempList.Sort ();
      tempList.ToArray ();
   } else
      Array.Sort (inputCharArray);
   if (order == "descending") {
      tempList.Sort ();
      tempList.Reverse ();
   }
   int count = inputStr.Count (c => c == splChar);
   for (int i = 0; i < count; i++)
      tempList.Add (splChar);
   for (int i = 0; i < tempList.Count - 1; i++)
      Console.Write (tempList[i] + ",");
   Console.Write (tempList.Last ());
}
 
