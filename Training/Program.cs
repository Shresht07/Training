static void SwapNum () {
   Console.Write ("Give a integer value for first variable: ");
   int a = int.Parse (Console.ReadLine ());
   Console.Write ("Now for second variable: ");
   int b = int.Parse (Console.ReadLine ());
   Console.WriteLine ($"Before swapping a = {a} and b = {b}");
   (a, b) = (b, a);
   Console.WriteLine ($"After swapping a = {a} and b = {b}");
}
SwapNum ();