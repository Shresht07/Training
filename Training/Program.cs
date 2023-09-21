//Integral part and fractional part calculator
decimal inputNum;
for (; ; ) {
   Console.Write ("Enter a decimal number: ");
   if (decimal.TryParse (Console.ReadLine (), out inputNum) && inputNum > 0)
      break;
   else
      Console.WriteLine ("Enter a valid decimal number");
}
string integralValues = IntegralPart (inputNum);
string fractionalValues = FractionalPart (inputNum);
IntegralPartWithSpaces (integralValues);
FractionalPartWithSpaces (fractionalValues);

/// <summary> Return the integral part of a input decimal number.</summary>
/// <decimal name="inputNum"></string>
static string IntegralPart (decimal inputNum) {
   int integralRes = 0;
   integralRes += (int)Math.Floor (inputNum);
   if (integralRes == 0)
      return "No Integral part";
   else
      return integralRes.ToString ();
}

/// <summary> Returns the fractional part of the input decimal number</summary>
/// <decimal name="inputNum"></string>
static string FractionalPart (decimal inputNum) {
   decimal fractionalRes = 0;
   fractionalRes += inputNum - Math.Floor (inputNum);
   if (fractionalRes == 0)
      return "No Fractional Part";
   else
      return fractionalRes.ToString ().Remove (0, 2);
}

/// <summary> Prints the Integral part of the input number with spaces </summary>
/// <string name="integralValues"></void>
static void IntegralPartWithSpaces (string integralValues) {
   char[] intPart = integralValues.ToCharArray ();
   Console.Write ("Integral Part: ");
   for (int i = 0; i < intPart.Length; i++)
      Console.Write (intPart[i] + " ");
}

/// <summary> Prints the fractional part of the input number with spaces </summary>
/// <string name="fractionalvalues"></void>
static void FractionalPartWithSpaces (string fractionalValues) {
   char[] fracPart = fractionalValues.ToCharArray ();
   Console.Write ("\nFractional Part: ");
   for (int i = 0; i < fracPart.Length; i++)
      Console.Write (fracPart[i] + " ");
}