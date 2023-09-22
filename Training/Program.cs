// Swaping of variables 
Console.Write ("Give a integer value for first variable: ");
int a = int.Parse (Console.ReadLine ());
Console.Write ("Now for second variable: ");
int b = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Before swapping a = {a} and b = {b}");
SwapNum (ref a, ref b);
Console.WriteLine ($"After swaping a = {a} and b = {b}");

/// <summary> Swaps the variable a and b to b and a respectively</summary>
/// <int name="a",<int name = "b">></void>
static void SwapNum (ref int a, ref int b) {
   int temp = a;
   a = b;
   b = temp;
}
