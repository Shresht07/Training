int inputNum;
for (; ; ) {
   Console.Write ("Enter the number to be swapped: ");
   if (int.TryParse (Console.ReadLine (), out inputNum))
      break;
   else
      Console.WriteLine ("Enter a valid number");
}
Console.Write ("Mention the first index to be swapped: ");
int index1 = int.Parse (Console.ReadLine ());
Console.Write ("Now the second index: ");
int index2 = int.Parse (Console.ReadLine ());
SwapOfIndices (inputNum, index1, index2);

static void SwapOfIndices (int inputNum, int index1, int index2) {
   char[] nums = inputNum.ToString ().ToCharArray ();
   if (index1 < nums.Length && index2 < nums.Length) {
      Console.Write ("Swapped number: ");
      (nums[index1], nums[index2]) = (nums[index2], nums[index1]);
   } else
      Console.Write ("Enter the index within the length of the input number ");
   for (int i = 0; i < nums.Length; i++) {
      if (index1 > nums.Length || index2 > nums.Length)
         break;
      else
         Console.Write (nums[i]);
   }
}
