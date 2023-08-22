//Asterisk printed in diamond form
Console.Write ("Enter number of rows: ");                                           //Mention number of rows to be printed in output 
int nrows = int.Parse (Console.ReadLine ());                                        //If an odd number is entered, for correct calculation 
if (nrows % 2 != 0) nrows++;
for (int rows1 = 1; rows1 <= ((2 * nrows + 1) / 2) - 2; rows1 += 2) {               //The variable rows1 is initiated with 1   
   SpacesAndStars (nrows, rows1);
}
for (int rows2 = ((2 * nrows + 1) / 2) - 1; rows2 >= 1; rows2 -= 2) {               //The rows2 is intiated with an element < the max no.of stars in first pyramid  
   SpacesAndStars (nrows, rows2);
}
static void SpacesAndStars (int nrows, int rows) {                                  //This method provides the necessary spaces and stars to be printed 
   for (int spaces2 = 1; spaces2 <= nrows - rows; spaces2++) {                      //Spaces are given as nrows - rows1 or rows2
      Console.Write (" ");
   }
   for (int stars2 = 1; stars2 <= rows; stars2++) {                                 //After entering the necessary spaces, stars are printed 
      Console.Write ("* ");
   }
   Console.Write ("\n");                                                            //To print asterisk in next line
}
