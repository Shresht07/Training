//Number reverse without string manipulation
int number;
while (true) {
   Console.Write ("Enter the number: ");                                       //Asks user for the number that needs to be reversed
   if (int.TryParse (Console.ReadLine (), out number) && number >= 0)
      break;
   else
      Console.WriteLine ("Enter a valid integer");                             //If the input is not a valid integer then prompts the user to enter a valid integer
}
int NumberRev (int number) {                                                   //This function reverses a number without string manipulation
   int result = 0;                                                             //A result variable is created to store the resultant number
   while (number != 0) {                                                       //If the given number is not equal to 0, the loop enters
      result = result * 10 + number % 10;                                      //Result is updated 
      number /= 10;                                                            //Number is also updated
   }
   return result;                                                              //Returns the result
}
Console.WriteLine ($"Reversed form of given number is {NumberRev (number)}");  //Prints the output in reverse form

//Checks whether the number is palindrome or not
if (number == NumberRev (number))
   Console.WriteLine ($"{NumberRev (number)} is a palindrome");
else
   Console.WriteLine ($"{NumberRev (number)} is not a palindrome");
