Console.Write ("Enter a string: ");
var redstr = Console.ReadLine ();
Console.WriteLine (ReducedString (redstr));
static string ReducedString (string redstr) {
   string str = "";
   for (int i = 0; i < redstr.Length; i++) {
      if (i < redstr.Length - 1 && redstr[i] == redstr[i + 1])
         i++;
      else
         str += redstr[i];
   }
   return str;
}
