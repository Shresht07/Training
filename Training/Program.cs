// Pascal traingle printer
Console.Write ("Mention the number of rows to be printed: ");
int number = int.Parse(Console.ReadLine());
PascalTriangle (number);
static void PascalTriangle (int number) {
   int c = 1;
   for (int lines = 1; lines <= number; lines++) {
      for (int space = 1; space <= number - lines; space++)
         Console.Write(" ");
      for (int i = 1; i < lines; i++) {
         Console.Write (" " + c + " ");
         c = c * (lines - i) / i;
      }
      Console.WriteLine (" 1");
   }
}
