int number, result = 0;
while (true) {                                                                  //Checks whether the given input is a valid integer
   Console.Write ("Enter the number: ");
   if (int.TryParse (Console.ReadLine (), out number) && number >= 0)
      break;
   else
      Console.WriteLine ("Enter a valid integer :(");                           //If the input is not valid, then displays the message
}
int DigitalRoot (int number) {                                                  //This method gives the digital root of the input number
   while (number != 0) {                                                        //Here the number is always not equal to 0, because the digital root of 0 is 0
      result += number % 10;                                                    //The remainder of number mod 10 is added to the result  
      number /= 10;                                                             //The number is then updated
   }
   if (result % 9 == 0)                                                         //Since the root must be a single digit, result mod 9 is done
      return 9;                                                                 //If the result is equal to 9, then returns 9
   else
      return result % 9;                                                        //Else result mod 9 is done
}
Console.WriteLine ($"Digital root --> {DigitalRoot (number)}");                 //Prints the digital root of the input
