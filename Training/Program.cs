// Number conversion game --> Which converts a decimal number to binary equivalent or Hexadecimal equivalent number based on the user input 
int dec;
while (true) {
   Console.Write ("Enter a decimal number: ");                                                             //Accepts input from user as a decimal number
   if (int.TryParse (Console.ReadLine (), out dec))
      break;
   else
      Console.WriteLine ("Enter valid decimal number");
}
Console.Write ("Mention your conversion type: (B)inary/(H)exadecimal");                                    //Prompts the user to enter keys (B or b) for binary and (H or h) for hexadecimal connversion 
switch (Console.ReadKey (true).Key) {
   case ConsoleKey.B:
      Console.WriteLine ($"\nBinary equivalent --> {DecimalToBinary (dec)}");
      break;
   case ConsoleKey.H:
      Console.WriteLine ($"\nHexadecimal equivalent --> {DecimalToHex (dec)}");
      break;
   default:
      Console.WriteLine ("\nEnter a valid key");
      break;
}
string DecimalToBinary (int dec) {                                                                         //This function converts the decimal number to its equivlent binary number
   string binary = "";
   while (dec != 0) {                                                                                      //The decimal number is first divided by modulus operator
      binary = dec % 2 + binary;                                                                           //Remainder obtained in the previous line is added to the empty binary string
      dec /= 2;                                                                                            //Decimal number is update dby dividing it further by 2
   }
   return binary;                                                                                          //Returns the updated binary string as output
}
string DecimalToHex (int dec) {
   string hexChars = "123456789ABCDEF", hex = "";                                                          //Hexadecimal characters are defined in a string hexChars
   while (dec != 0) {
      hex += hexChars[dec % 16 - 1];                                                                       //Empty string hex is updated by dividing the decimal number by 16 using modulo operator,
      dec /= 16;                                                                                           //After which the quotient indicates the index of the hexChars string
   }                                                                                                       //And is added to the empty string 
   return hex;
}
 
