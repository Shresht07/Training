//Number to Words or Roman numericals representation converter 
int number;
while (true) {
   Console.Write ("For words representation, enter within 9000000000 \nFor roman numeral conversion, enter within 39999 \nEnter the number:");                                                                       
   if (int.TryParse (Console.ReadLine (), out number) && (number >= 0))                                       //Accepts if only a valid integer is entered
      break;
   else
      Console.WriteLine ("Enter a valid number");                                                             //Else prompts to enter valid key
}
Console.WriteLine ("Mention your conversion type: (W)ords or (R)oman numerals");
switch (Console.ReadKey (true).Key) {                                                                         //Accepts w or W for words converter
   case ConsoleKey.W:
      var words = NumberToWords (number);
      Console.WriteLine ($"\nWords representation: {words}");
      break;
   case ConsoleKey.R:                                                                                         //R or r for roman numerals converter
      var roman = NumberToRoman (number);
      Console.WriteLine ($"\nRoman numerical representation: {roman}");
      break;
   default:
      Console.WriteLine ("\nEnter a valid number");
      break;
}
string NumberToWords (long number) {                                                                          //This function converts an integer to its words representation
   string words = "";
   if (number < 0) return ($"Minus {NumberToWords (Math.Abs (number))}");                                     //If number is less than 0 (i.e.,) negative numbers, it is represented with a minus sign in front of it
   if ((number / 10000000) > 0) {
      words += NumberToWords (number / 10000000) + " crores ";                                                //Input is divided by 1 crore and "crore" word is added to the empty word string  
      number %= 10000000;                                                                                     //Number is then updated 
   }
   if ((number / 100000) > 0) {                                                                               //Same steps is carried out for lakh, thousand, hundred  
      words += NumberToWords (number / 100000) + " lakhs ";
      number %= 100000;
   }
   if ((number / 1000) > 0) {
      words += NumberToWords (number / 1000) + " thousand ";
      number %= 1000;
   }
   if ((number / 100) > 0) {
      words += NumberToWords (number / 100) + " hundred ";
      number %= 100;
   }
   if (number >= 0) {                                                                                         //If number is greater than zero
      if (words != "")                                                                                        //And words is no longer an empty string  
         words += "and ";
      var units = new[] { "Zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
      var tens = new[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
      if (number < 20)                                                                                        //If the number is lesser than 20
         words += units[number];                                                                              //Then the index from the units array is added to the words string 
      else {
         words += tens[number / 10 - 2];
         if (number % 10 > 0)
            words += " " + units[number % 10];
      }
   }
   return words;
}
string NumberToRoman (int number) {                                                                          //This method converts the number into roman numeral representation
   if (number == 0) return "No symbol";
   if (number < 0) return ($"Minus {NumberToRoman (Math.Abs (number))}");
   var symbols = new[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M", "MV!", "V!", "MX!", "X!" };
   var val = new[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000, 4000, 5000, 9000, 10000 };
   string roman = "";
   for (int i = val.Length - 1; i >= 0; i--) {                                                               //Checks the val array in reverse order
      while (number >= val[i]) {                                                                             //If number is greter than or equal to the val's ith elements the loop goes in
         roman += symbols[i];                                                                                //The roman symbols are added to the empty roman string
         number -= val[i];                                                                                   //The number is then updated
      }
   }
   return roman;
}
