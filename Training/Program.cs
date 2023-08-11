//Prime number checker 
int number;
while (true) {
   Console.Write ("Enter the number: ");                          //Gets an input integer from user
   if (int.TryParse (Console.ReadLine (), out number))
      break;
   else
      Console.WriteLine ("Enter a valid integer :(");
}
bool IsPrime (int number) {                                      //A Boolean function which returns true when the input number is prime
   if (number <= 1)                                              //If number is less then 1, then it might not be a prime number
      return false;
   for (int i = 2; i * i <= number; i++) {
      if (number % i == 0)                                       //If input is divisible by i, then IsPrime returns it not prime  
         return false;
   }
   return true;
}
if (IsPrime (number))
   Console.WriteLine ($"{number} is a prime number");
else
   Console.WriteLine ($"{number} is not a prime number");
