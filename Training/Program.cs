//Password validity checker which checks if the input password is valid or not
while (true) {                                                                                              //
   Console.Write ("Password: ");
   string password = Console.ReadLine ();
   if (StrongPassword (password) == "") {
      Console.WriteLine ("Accepted");
      break;
   } else {
      Console.WriteLine ($"{StrongPassword (password)}\nInvalid password. Try again.");
   }
}
static string StrongPassword (string password) {
      string errorMsg = "";
      errorMsg += (password.Length <= 6) ? "Password must contain atleast 6 characters\n" : errorMsg = "";
      errorMsg += (!password.Any (char.IsUpper)) ? "Password should start with an uppercase letter\n" : errorMsg = "";
      errorMsg += (!password.Any (char.IsLower)) ? "Password must contain at least one lowercase letter\n" : errorMsg = "";
      errorMsg += (!password.Any (char.IsDigit)) ? "Password must contain at least one digit\n" : errorMsg = "";
      errorMsg += (!password.Any (char.IsSymbol) && !password.Any (char.IsPunctuation)) ? "Password must contain at least one special character\n" : errorMsg = "";
      return errorMsg;
}