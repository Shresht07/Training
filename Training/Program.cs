int nArmsNum;
for (; ; ) {
   Console.Write ("Mention the Nth number of armstrong number to be displayed within 25: ");
   if (int.TryParse (Console.ReadLine (), out nArmsNum) && nArmsNum <= 25)
      break;
   else if (nArmsNum > 25)
      Console.WriteLine ("Enter within the given range");
   else
      Console.WriteLine ("Enter a valid integer");
}
static long NthArmstrongNumber (int nArmsNum) {
   long[] result = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 371, 407, 1634, 8208, 9474, 54748, 92727, 93084, 548834, 1741725, 4210818, 9800817, 9926315, 24678051 };
   return result[nArmsNum - 1];
}
switch (nArmsNum) {
   case 1:
      Console.Write ($"The {nArmsNum}st armstrong number is {NthArmstrongNumber (nArmsNum)}");
      break;
   case 2:
      Console.Write ($"The {nArmsNum}nd armstrong number is {NthArmstrongNumber (nArmsNum)}");
      break;
   case 3:
      Console.Write ($"The {nArmsNum}rd armstrong number is {NthArmstrongNumber (nArmsNum)}");
      break;
   default:
      Console.WriteLine ($"The {nArmsNum}th armstrong number is {NthArmstrongNumber (nArmsNum)}");
      break;
}
