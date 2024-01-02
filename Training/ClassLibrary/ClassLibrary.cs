// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2023.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// ClassLibrary.cs
// Implement custom double.Parse method that takes a string and returns its double equivalent value.
// ------------------------------------------------------------------------------------------------
namespace ClassLibrary {
   /// <summary>Provides methods for parsing strings into double values</summary>
   public class CustomDouble {
      #region Public Methods ----------------------------------------
      /// <summary>Parses the specified string into its double equivalent value</summary>
      /// <param name="input">The input string to be parsed</param>
      /// <returns>Returns the double equivalent of the input string</returns>
      public double Parse (string input) {
         input = input.ToLower ().Trim ();
         double result = 0;
         bool isNegative = false;
         int startIndex = 0;
         int integerPart = 0;
         double fractionalPart = 0;
         bool hasFractionalPart = false;
         double fractionalMultiplier = 0.1;
         bool hasExponent = false;
         int exponent = 0;
         bool isExponentNegative = false;
         int e = input.IndexOf ('e');

         if ((input.Count (ch => ch is 'e') is 1) &&
             e > 0 && (input[e - 1] is '+' or '-'))
            return double.NaN;

         if (input.Count (op => op is '+') + input.Count (op => op is '-') > 1) return double.NaN;

         if (input.StartsWith ('.') || input.EndsWith ('.') ||
             string.IsNullOrWhiteSpace (input) || input.StartsWith ('e') || input.EndsWith ('e'))
            return double.NaN;

         if (input.Length > 0 && (input[0] is '-' or '+')) {
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
            } else if (c is '.') {
               if (hasFractionalPart) return double.NaN;
               hasFractionalPart = true;
            } else if (c is 'e') {
               hasExponent = true;
               if (i + 1 < input.Length) {
                  i++;
                  if (input[i] is '-') {
                     isExponentNegative = true;
                     i++;
                  } else if (input[i] is '+') i++;

                  while (i < input.Length && char.IsDigit (input[i])) {
                     exponent = exponent * 10 + (input[i] - '0');
                     i++;
                  }
               }
               break;
            } else return double.NaN;
         }
         result = integerPart + fractionalPart;
         if (hasExponent) result = (integerPart + fractionalPart) * Math.Pow (10, isExponentNegative ? -exponent : exponent);
         if (isNegative) result = -result;
         return Math.Round (result, 4);
      }
      #endregion
   }
}