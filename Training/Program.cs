//Password validity checker which checks if the input password is valid or not
while (true) {
   Console.Write ("Password: ");
   string password = Console.ReadLine ();
   if (StrongPassword (password)) {
      Console.WriteLine ("Accepted");
      break;
   } else {
      Console.WriteLine ("\nInvalid password. Try a new password.");
   }
   bool StrongPassword (string password) {
      if (!password.Any (char.IsUpper)) {
         Console.WriteLine ("Password must start with a Uppercase");
         return false;
      }
      if (!password.Any (char.IsDigit)) {
         Console.WriteLine ("Password must atleast contain a digit");
         return false;
      }
      if (!password.Any (char.IsLower)) {
         Console.WriteLine ("Password must contain atleast one lowercase");
         return false;
      }
      if (!password.Any (char.IsSymbol) && !password.Any (char.IsPunctuation)) {
         Console.WriteLine ("Password must contain atleast one special character");
         return false;
      }
      if (password.Length <= 6) {
         Console.WriteLine ("Password must contain atleast 6 characters");
         return false;
      }
      return true;
   }
}
