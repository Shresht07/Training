string inputStr = InputValidityChecker ("Enter a string: ", "Enter a valid string. Empty string is not allowed");
string inSplChar = InputValidityChecker("Mention the special character to be swapped: ", "Enter a valid special character. Entering empty special character is not allowed");
Console.Write ("Mention the order: ");
string order = Console.ReadLine ();
SortAndSwapSplChars (inputStr, inSplChar, order);

static void SortAndSwapSplChars (string inputStr, string inSplChar, string order) {
   char splChar = char.Parse (inSplChar);
   List<char> tempList = inputStr.ToList ();
   if (inputStr.Contains (splChar)) {
      tempList.RemoveAll (ch => ch == splChar);
      tempList.Sort ();
      tempList.ToArray ();
   } else tempList.Sort ();
   tempList = order == "descending" ? tempList.OrderDescending ().ToList () : tempList.Order ().ToList ();
   int count = inputStr.Count (c => c == splChar);
   for (int i = 0; i < count; i++)
      tempList.Add (splChar);
   for (int i = 0; i < tempList.Count - 1; i++)
      Console.Write (tempList[i] + ",");
   Console.Write (tempList.Last ());
}

static string InputValidityChecker (string questions, string warningMsg) {
   string input;
   for (; ; ) {
      Console.Write (questions);
      input = Console.ReadLine ();
      if (input != "") break;
      else Console.WriteLine (warningMsg);
   }
   return input;
}
