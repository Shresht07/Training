// Chess Board 
using System.Text;
System.Console.OutputEncoding = new UnicodeEncoding ();

// First Row --> Black king,queen,bishops,elephants and horses
Console.Write ("\u250c\u2500\u2500\u2500");
for (int i = 0; i < 7; i++)
   Console.Write ("\u252c\u2500\u2500\u2500");
Console.WriteLine ("\u2510\n\u2502" + " \u265c " + "\u2502" + " \u265e " + "\u2502" + " \u265d " + "\u2502" + " \u265b " + "\u2502" + " \u265a " + "\u2502" + " \u265d " + "\u2502" + " \u265e " + "\u2502" + " \u265c " + "\u2502");
Console.Write ("\u251c\u2500\u2500\u2500");
for (int i = 0; i < 7; i++)
   Console.Write ("\u253c\u2500\u2500\u2500");
Console.WriteLine ("\u2524");

// Second Row --> Black pawns
Console.WriteLine ("\u2502" + " \u265f" + "\u2502" + " \u265f" + "\u2502" + " \u265f" + "\u2502" + " \u265f" + "\u2502" + " \u265f" + "\u2502" + " \u265f" + "\u2502" + " \u265f" + "\u2502" + " \u265f" + "\u2502");
Console.Write ("\u251c\u2500\u2500\u2500");
for (int i = 0; i < 7; i++)
   Console.Write ("\u253c\u2500\u2500\u2500");
Console.Write ("\u2524");

// Empty rows in the middle 
for (int j = 0; j < 4; j++) {
   Console.Write ("\n\u2502" + "   " + "\u2502" + "   " + "\u2502" + "   " + "\u2502" + "   " + "\u2502" + "   " + "\u2502" + "   " + "\u2502" + "   " + "\u2502" + "   " + "\u2502");
   Console.Write ("\n\u251c\u2500\u2500\u2500");
   for (int i = 0; i < 7; i++)
      Console.Write ("\u253c\u2500\u2500\u2500");
   Console.Write ("\u2524");
}

// Seventh Row --> 
Console.WriteLine ("\n\u2502" + " \u2659 " + "\u2502" + " \u2659 " + "\u2502" + " \u2659 " + "\u2502" + " \u2659 " + "\u2502" + " \u2659 " + "\u2502" + " \u2659 " + "\u2502" + " \u2659 " + "\u2502" + " \u2659 " + "\u2502");
Console.Write ("\u251c\u2500\u2500\u2500");
for (int i = 0; i < 7; i++)
   Console.Write ("\u253c\u2500\u2500\u2500");
Console.WriteLine ("\u2524");

// Eighth Row
Console.WriteLine ("\u2502" + " \u2656 " + "\u2502" + " \u2658 " + "\u2502" + " \u2657 " + "\u2502" + " \u2655 " + "\u2502" + " \u2654 " + "\u2502" + " \u2657 " + "\u2502" + " \u2658 " + "\u2502" + " \u2656 " + "\u2502");
Console.Write ("\u2514\u2500\u2500\u2500");
for (int i = 0; i < 7; i++)
   Console.Write ("\u2534\u2500\u2500\u2500");
Console.WriteLine ("\u2518");
