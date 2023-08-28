Console.Write ("Enter a string: ");
var redstr = Console.ReadLine ();
Console.WriteLine (ReducedString (redstr));
static string ReducedString (string redstr) {
   string str = "";
   for (int i = 0; i < redstr.Length;) {
      if (i < redstr.Length - 1 && redstr[i] == redstr[i + 1])
         i += 2;
      else {
         str += redstr[i];
         i++;
      }
   }
   return str;
}
