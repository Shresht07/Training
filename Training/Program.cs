//Multiplication table
int number, i = 1;
while (true) {                                                                               //Checks whether the input integer is valid or not
   Console.Write ("Enter the number: ");
   if (int.TryParse (Console.ReadLine (), out number) && (number >= 0) || (number <= 0))
      break;
   else
      Console.WriteLine ("Enter a valid integer :(");                                        //If not a valid integer, prompts the user to enter a valid one
}
do {
   Console.WriteLine ($"{number} *{i,3} = {number * i}");                                    //Prints Multiplication table in the specific way
   i++;                                                                                      //increments by 1
} while (i <= 10);                                                                           //Checks whether i is lesser than or equal to 10
