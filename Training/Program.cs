Console.Write ("Mention the amount money you have: ");
int amount = int.Parse (Console.ReadLine ());
Console.Write ("Enter the price of a chocolate: ");
int price = int.Parse (Console.ReadLine ());
Console.Write ("Mention number of wrappers can be exchanged in order to get one chocolate: ");
int wrappers = int.Parse (Console.ReadLine ());
(int, int, int) result = ChocolateWrappers (amount, price, wrappers);
Console.Write ($"Maxmimum number of chocolates bought(C): {result.Item2}\nBalance amount(X): {result.Item1}\nBalance no.of wrappers(W): {result.Item3}");
static (int, int, int) ChocolateWrappers (int amount, int price, int wrappers) {
   int maxChocolates = amount / price, balAmount = amount % price, balWrappers = maxChocolates;
   while (balWrappers >= wrappers) {
      balWrappers -= wrappers;
      balWrappers++;
      maxChocolates++;
   }
   return (balAmount, maxChocolates, balWrappers);
}
