// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO:Given a character array A, along with special character S and sort order O (default order is Ascending)
// print the sorted array by keeping the elements matching S to the last of the array>
// ---------------------------------------------------------------------------------------
namespace Training {
   #region TestProgram --------------------------------------------------------------------------
   /// <summary>Sort and swap special character</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>This method prints swaped characters</summary>
      /// <param name="args">arguments</param>
      private static void Main (string[] args) {
         string inputStr = GetInput ("Enter a string: ", "Enter a valid string. Empty string is not allowed");
         string inSplChar = GetInput ("Mention the special character to be swapped: ", "Enter a valid special character. Entering empty special character is not allowed");
         Console.Write ("Mention whether the order is (d)escending or (a)escending: ");
         string order = Console.ReadLine ();
         SortAndSwapSplChars (inputStr, inSplChar, order);
      }

      /// <summary>This method sorts and swaps according to the input special character</summary>
      /// <param name="inputStr">User input</param>
      /// <param name="inSplChar">User input for special character</param>
      /// <param name="order">arrangement order</param>
      /// <returns>input integer</returns>
      static void SortAndSwapSplChars (string inputStr, string inSplChar, string order) {
         char splChar = char.Parse (inSplChar);
         List<char> tempList = inputStr.ToList ();
         if (inputStr.Contains (splChar))
            tempList.RemoveAll (ch => ch == splChar);
         tempList.Sort ();
         tempList = order == "d" ? tempList.OrderDescending ().ToList () : tempList.Order ().ToList ();
         int count = inputStr.Count (c => c == splChar);
         for (int i = 0; i < count; i++)
            tempList.Add (splChar);
         Console.Write (string.Join (",", tempList));
      }

      /// <summary>Checks whether the input is valid or not</summary>
      /// <param name="input">User input</param>
      /// <returns>input integer</returns>
      static string GetInput (string questions, string warningMsg) {
         string input;
         for (; ; ) {
            Console.Write (questions);
            input = Console.ReadLine ();
            if (input != "")
               break;
            else
               Console.WriteLine (warningMsg);
         }
         return input;
      }
   }
      #endregion
   #endregion
}
