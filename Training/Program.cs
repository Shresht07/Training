//Asterisk printed in diamond form
for(int rows1 = 1; rows1 <= 9; rows1 += 2) {                             //Printing a pyramid of stars first with 5 rows
   for (int spaces1 = 1; spaces1 <= 10 - rows1; spaces1++) {             //Spaces are given appropriately from the margin
      Console.Write (" ");
   }
   for (int stars1 = 1; stars1 <= rows1; stars1++) {                     //Stars are printed according to spaces 
      Console.Write ("* ");
   }
   Console.WriteLine();                                                  //Printing stars in pyramid order
}
//Printing a pyramind of stars in reverse order right below the above pyramid
for (int rows2 = 7; rows2 >= 1; rows2 -= 2) {                            //Printing with 7 stars in the first row       
   for (int spaces2 = 1; spaces2 <= 10 - rows2; spaces2++) {             //spacing with n - rows2 number of spaces 
      Console.Write (" ");
   }
   for (int stars2 = 1; stars2 <= rows2; stars2++) {                     //stars are printed according to rows2
      Console.Write ("* ");
   }
   Console.WriteLine();                                                  //Printing the stars in reverse pyramid order
}
