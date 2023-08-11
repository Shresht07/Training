//This code gives LCM and GCD of given two input numbers
int num1, num2;
while (true) {                                                                     //Checks whether the input is a valid integer or not 
   Console.Write ("Enter First Number: ");
   if (int.TryParse (Console.ReadLine (), out num1) && num1 >= 0)
      break;
   else
      Console.WriteLine ("Enter a valid integer :( ");
}
while (true) {
   Console.Write ("Enter Second Number: ");
   if (int.TryParse (Console.ReadLine (), out num2) && num2 >= 0)
      break;
   else
      Console.WriteLine ("Enter a valid integer :( ");
}
int GCD (int num1, int num2) {                                                     //GCD Function gives GCD of two input numbers
   if (num2 == 0)                                                                  //Base Condition of the recursion method is given
      return num1;
   else
      return GCD (num2, num2 % num1);                                              //returns the GCD of two numbers
}
int LCM = (num1 * num2) / GCD (num1, num2);                                        //LCM is calculated by the formula, product of two numbers ÷ GCD of two numbers.
Console.WriteLine ($"LCM of {num1} and {num2} is {LCM}");
Console.WriteLine ($"GCD of {num1} and {num2} is {GCD (num1, num2)}");
