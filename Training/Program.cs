Console.Write ("Enter a string: ");
string isostr = Console.ReadLine ();
Console.WriteLine (IsIsogram(isostr)?"Its a isogram":"Not an isogram");
static bool IsIsogram (string isostr) {
   char[] result = isostr.ToArray ();
   Array.Sort(result);
   for (int i = 0; i < isostr.Length-1;i++) {
      if (result[i] == result[i + 1])
         return false;
   }
   return true;
}
