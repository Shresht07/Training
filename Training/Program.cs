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
int nthArmsNum = CalculateNthArmstrong (nArmsNum);
switch (nArmsNum) {
   case 1:
      Console.Write ($"The {nArmsNum}st armstrong number is {nthArmsNum}");
      break;
   case 2:
      Console.Write ($"The {nArmsNum}nd armstrong number is {nthArmsNum}");
      break;
   case 3:
      Console.Write ($"The {nArmsNum}rd armstrong number is {nthArmsNum}");
      break;
   default:
      Console.Write ($"The {nArmsNum}th armstrong number is {nthArmsNum}");
      break;
}

static int ArmstrongNumber (int inputNumber) {
   List<int> digits = new ();
   int result = 0;
   if (inputNumber == 0)
      return 0;
   while (inputNumber > 0) {
      digits.Add (inputNumber % 10);
      inputNumber /= 10;
   }
   foreach (int digit in digits) {
      result += (int)Math.Pow (digit, digits.Count);
   }
   return result;
}

static int CalculateNthArmstrong (int nArmsNum) {
   if (nArmsNum == 1) return 0;
   int count = 1, num = 1;
   while (count < nArmsNum) {
      num++;
      if (ArmstrongNumber (num) == num)
         count++;
   }
   return num;
}
