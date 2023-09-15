decimal inputNum;
for (; ; ) {
   Console.WriteLine ("Enter a decimal number: ");
   if (decimal.TryParse (Console.ReadLine (), out inputNum) && inputNum > 0)
      break;
   else
      Console.WriteLine ("Enter a valid decimal number");
}
Console.WriteLine ($"Integral Part: {IntegralPart (inputNum)}\nFractional Part: {Fractionalpart (inputNum)}");
static int IntegralPart (decimal inputNum) {
   int integralRes = 0;
   integralRes += (int)Math.Floor (inputNum);
   if (integralRes == 0)
      return 0;
   else 
      return integralRes;
}
static string Fractionalpart(decimal inputNum) {
   decimal fractionalRes = 0;
   fractionalRes += inputNum - IntegralPart(inputNum);
   if (fractionalRes == 0)
      return "No Fractional Part";
   else
      return fractionalRes.ToString ().Remove (0, 2).Insert(1," ");
}

