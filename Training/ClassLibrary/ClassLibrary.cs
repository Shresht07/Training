namespace ClassLibrary {
   public class CustomDouble {
      public double Parse (string input) {
         input = input.Trim ();
         double result = 0;
         bool isNegative = false;
         int startIndex = 0;
         double integerPart = 0;
         double fractionalPart = 0;
         bool hasFractionalPart = false;
         double fractionalMultiplier = 0.1;
         bool hasExponent = false;
         int exponent = 0;
         bool isExponentNegative = false;

         if ((input.Count (ch => ch == 'e' || ch == 'E') == 1) &&
             ((input.IndexOf ('e') > 0 && (input[input.IndexOf ('e') - 1] == '+' || input[input.IndexOf ('e') - 1] == '-')) ||
              (input.IndexOf ('e') < input.Length - 1 && (input[input.IndexOf ('e') + 1] == '+' || input[input.IndexOf ('e') + 1] == '-')))) return double.NaN;

         if (input.StartsWith ('.') || input.EndsWith ('.') ||
             string.IsNullOrWhiteSpace (input) || input.StartsWith ('e') || input.EndsWith ('e'))
            return double.NaN;

         if (input.Length > 0 && (input[0] == '-' || input[0] == '+')) {
            isNegative = input[0] == '-';
            startIndex = 1;
         }

         for (int i = startIndex; i < input.Length; i++) {
            char c = input[i];
            if (char.IsDigit (c)) {
               int digit = c - '0';
               if (!hasFractionalPart) integerPart = integerPart * 10 + digit;
               else {
                  fractionalPart += digit * fractionalMultiplier;
                  fractionalMultiplier *= 0.1;
               }
               if (hasExponent) exponent = exponent * 10 + digit;
            } else if (c == '.') {
               if (hasFractionalPart) return double.NaN;
               hasFractionalPart = true;
            } else if (c == 'e' || c == 'E') {
               hasExponent = true;
               if (i + 1 < input.Length) {
                  i++;
                  if (input[i] == '-') {
                     isExponentNegative = true;
                     i++;
                  } else if (input[i] == '+') i++;

                  while (i < input.Length && char.IsDigit (input[i])) {
                     exponent = exponent * 10 + (input[i] - '0');
                     i++;
                  }
               }
               break;
            } else return double.NaN;
         }

         if (hasExponent) result = (integerPart + fractionalPart) * Math.Pow (10, isExponentNegative ? -exponent : exponent);
         else result = integerPart + fractionalPart;

         if (isNegative) result = -result;
         return Math.Round (result, 4);
      }
   }
}