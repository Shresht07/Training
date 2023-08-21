//This code gives LCM and GCD of given multiple numbers
Console.Write ("Mention the Count of numbers for GCD calculation: ");
int nNum = int.Parse (Console.ReadLine ());
List<int> numbers = GetNumbers (nNum);
Console.WriteLine ($"The GCD of all input numbers --> {GCDforNnum (numbers)}");
Console.WriteLine ($"The LCM of all input numbers --> {LCMforNnum (numbers)}");
List<int> GetNumbers (int nNum) {
   List<int> numbers = new ();
   for (int a = 1; a <= nNum; a++) {
      Console.Write ($"Enter number {a}: ");
      int num = int.Parse (Console.ReadLine ());
      numbers.Add (num);
   }
   return numbers;
}
int GCD (int num1, int num2) {
   if (num2 == 0)
      return num1;
   else
      return GCD (num2, num1 % num2);
}
int GCDforNnum (List<int> numbers) {
   int result = numbers[0];
   for (int i = 1; i < numbers.Count; i++) {
      result = GCD (result, numbers[i]);
   }
   return result;
}
int LCM (int num1,int num2) {
   int lcm = num1 * num2 / GCD (num1,num2);
   return lcm;
}
int LCMforNnum (List<int> numbers) {
   int resultLCM = numbers[0];
   for (int i = 1; i < numbers.Count; i++) {
      resultLCM = LCM (resultLCM, numbers[i]);
   }
   return resultLCM;
}
