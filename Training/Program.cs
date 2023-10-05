int amount = InputValidityChecker ("Mention the amount of money you have: ", "Enter amount as an integer value");
int price = InputValidityChecker("Enter the price of a chocolate: ", "Enter the price as an integer value");
int wrappers = InputValidityChecker("Mention number of wrappers can be exchanged in order to get one chocolate: ", "Enter a valid integer as an input");
(int x, int c, int w) = ChocolateWrappers (amount, price, wrappers);
Console.Write ($"Maxmimum number of chocolates bought(C): {c}\nBalance amount(X): {x}\nBalance no.of wrappers(W): {w}");
static (int c, int x, int w) ChocolateWrappers (int amount, int price, int wrappers) {
   int maxChocolates = amount / price, balAmount = amount % price, balWrappers = maxChocolates;
   while (balWrappers >= wrappers) {
      balWrappers -= wrappers;
      balWrappers++;
      maxChocolates++;
   }
   return (balAmount, maxChocolates, balWrappers);
}

static int InputValidityChecker (string questions,string warningMsg) {
   int input;
   for (; ; ) {
      Console.Write (questions);
      if (int.TryParse (Console.ReadLine (), out input) && input >= 0)
         break;
      else
         Console.WriteLine (warningMsg);
   }
   return input;
}