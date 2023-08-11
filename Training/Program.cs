// Number conversion game --> Which converts a decimal number to binary equivalent or Hexadecimal equivalent number based on the user input 
int dec;
while (true) {
   Console.Write ("Enter a decimal number: ");                              //Accepts input from user as a decimal number
   if (int.TryParse (Console.ReadLine (), out dec))
      break;
   else
      Console.WriteLine ("Enter valid decimal number :( ");
}
Console.Write ("Binary or Hexadecimal? (B/H): ");                           //prompts the user to enter keys (B or b) fo0r binary and (H or h) for hexadecimal connversion 
switch (Console.ReadKey (true).Key) {
   case ConsoleKey.B:
      string binary = DecimalToBinary (dec);
      Console.WriteLine ($"\nBinary equivalent: {binary}");
      break;
   case ConsoleKey.H:
      string hex = DecimalToHex (dec);
      Console.WriteLine ($"\nHexadecimal equivalent: {hex}");
      break;
   default:
      Console.WriteLine ("\nEnter a valid key :(");
      break;
}
string DecimalToBinary (int dec) {                                         //This function converts the decimal number to its equivlent binary number
   string binary = ""; int binRemainder = 0;
   if (dec == 0)
      return "0";
   while (dec > 0) {
      binRemainder = dec % 2;                                               //The decimal number is first divided by modulus operator
      binary = binRemainder + binary;                                       //remainder obtained in the previous line is added to the empty binary string
      dec /= 2;                                                             //decimal number is update dby dividing it further by 2
   }
   return binary;                                                           //returns the updated binary string as output
}
string DecimalToHex (int dec) {
   if (dec == 0)
      return "0";
   string hexChars = "0123456789ABCDEF";                                    //hexadecimal characters are defined in a string as hexChars
   string hex = "";
   while (dec > 0) {
      hex += hexChars[dec % 16];                                            //empty string hex is updated by dividing the decimal number by 16 using modulo operator,
      dec /= 16;                                                            //after which the quotient indicates the index of the hexChars string
   }                                                                        //and is added to the empty string 
   return hex;
}
