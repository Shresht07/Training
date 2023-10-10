// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.                                               
// ---------------------------------------------------------------------------      
// Program.cs                                                                    
// <TODO: Write a function to determine the nth Armstrong number input index that needs to be passed as a command-line argument to the application.
// For example, Armstrong.exe 12 should print as 371. Maximum input can be restricted to 25>
// ---------------------------------------------------------------------------------------
namespace Training {
   #region TestProgram --------------------------------------------------------------------------
   /// <summary>Finding the Nth Armstrong number</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      private static void Main (string[] args) {
         for (; ; ) {
            Console.Write ("Mention the Nth number of armstrong number to be displayed within 25: ");
            if (int.TryParse (Console.ReadLine (), out int mArmsNum) && mArmsNum <= 25) {
               int nthArmsNum = CalculateNthArmstrong (mArmsNum);
               Console.WriteLine (nthArmsNum);
               continue;
            } else if (mArmsNum > 25)
               Console.WriteLine ("Enter within the given range");
            else
               Console.WriteLine ("Enter a valid integer");
         }
         
         /// <summary>Takes input of the user and returns true if input is armstrong number</summary>
         /// <param name="inputNumber">User input</param>
         /// <returns>If the input is armstrong number or not</returns>
         static bool IsArmstrongNumber (int inputNumber) {
            int temp = inputNumber;
            int result = 0;
            while (temp > 0) {
               int remainder = temp % 10;
               result += (int)Math.Pow (remainder, inputNumber.ToString ().Length);
               temp /= 10;
            }
            return result == inputNumber;
         }
         
         /// <summary>Calculates the Nth Armstrong number</summary>
         /// <param name="armsNum">User input</param>
         /// <returns>Nth armstrong number</returns>
         static int CalculateNthArmstrong (int armsNum) {
            if (armsNum == 0) return 0;
            int count = 1, num = 1;
            while (count < armsNum) {
               num++;
               if (IsArmstrongNumber (num))
                  count++;
            }
            return num;
         }
      }
      #endregion
   }
   #endregion
}
