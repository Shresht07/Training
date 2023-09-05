// Chess Board 
using System.Text;
System.Console.OutputEncoding = new UnicodeEncoding ();

// First Row
Console.Write ("\u250c\u2500\u2500\u2500");
for (int i = 0; i < 7; i++)
   Console.Write ("\u252c\u2500\u2500\u2500");
Console.WriteLine ("\u2510");
Console.WriteLine ("\u2502 \u265c \u2502 \u265e \u2502 \u265d \u2502 \u265b \u2502 \u265a \u2502 \u265d \u2502 \u265e \u2502 \u265c \u2502");
BottomLine();

// Second Row
Pawns ("\u265f");
BottomLine();

// Empty rows in the middle 
for (int j = 0; j < 4; j++) {
   Console.WriteLine ("\u2502   \u2502   \u2502   \u2502   \u2502   \u2502   \u2502   \u2502   \u2502");
   BottomLine ();
}

// Seventh Row
Pawns ("\u2659");
BottomLine ();

// Eighth Row
Console.WriteLine ("\u2502 \u2656 \u2502 \u2658 \u2502 \u2657 \u2502 \u2655 \u2502 \u2654 \u2502 \u2657 \u2502 \u2658 \u2502 \u2656 \u2502");
Console.Write ("\u2514\u2500\u2500\u2500");
for (int i = 0; i < 7; i++)
   Console.Write ("\u2534\u2500\u2500\u2500");
Console.WriteLine ("\u2518");

static void BottomLine () {
   Console.Write ("\u251c\u2500\u2500\u2500");
   for (int i = 0; i < 7; i++)
      Console.Write ("\u253c\u2500\u2500\u2500");
   Console.WriteLine ("\u2524");
}

static void Pawns (string unicode) {
   Console.WriteLine ($"\u2502 {unicode} \u2502 {unicode} \u2502 {unicode} \u2502 {unicode} \u2502 {unicode} \u2502 {unicode} \u2502 {unicode} \u2502 {unicode} \u2502");
}
