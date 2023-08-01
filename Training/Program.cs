int LowLimit = 0, HighLimit = 100, nGuesses = 0, NewLimit = (LowLimit + HighLimit) / 2;
do {
   Console.WriteLine ($"Find the guessed number :) \n Is the number greater than {NewLimit}: Y/N");
   switch (Console.ReadKey ().Key) {
      case ConsoleKey.Y:
         LowLimit = NewLimit;
         break;
      case ConsoleKey.N:
         HighLimit = NewLimit;
         break;
      default:
         Console.WriteLine ("Enter valid key :(");
         break;
   }
   nGuesses++;
   NewLimit = (LowLimit + HighLimit) / 2;
   Console.WriteLine ();
} while (nGuesses < 6);
Console.WriteLine ($"{NewLimit + 1} is the guessed number ;)");
