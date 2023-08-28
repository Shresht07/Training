//Password validity checker which checks if the input password is valid or not
while (true) {                                                                            // An infinite loop to ask the user to enter a valid password again 
   Console.Write ("Password: ");                                                          
   string password = Console.ReadLine ();
   if (StrongPassword (password) == "") {                                                 // If there are no error messages, then accepts the password 
      Console.WriteLine ("Accepted");
      break;
   } else {
      Console.WriteLine ($"{StrongPassword (password)}\nInvalid password. Try again.");   // Else asks for a valid password
   }
}
static string StrongPassword (string password) {
      string errorMsg = "";                                                                                                                                            
      errorMsg += (password.Length <= 6) ? "Password must contain atleast 6 characters\n" : errorMsg = "";                                                            // Checks whether the input is less than 6 characters 
      errorMsg += (!char.IsUpper (password[0])) ? "Password should start with an uppercase letter\n" : errorMsg = "";                                                 // Checks whether the password starts with an Uppercase letter
      errorMsg += (!password.Any (char.IsLower)) ? "Password must contain at least one lowercase letter\n" : errorMsg = "";                                           // Checks whether the input has any lowercase letter in it
      errorMsg += (!password.Any (char.IsDigit)) ? "Password must contain at least one digit\n" : errorMsg = "";                                                      // Checks whether the input has any digits in it 
      errorMsg += (!password.Any (char.IsSymbol) && !password.Any (char.IsPunctuation)) ? "Password must contain at least one special character\n" : errorMsg = "";   // Checks whether the input has a digit it or not 
      return errorMsg;                                                                                                                                                // Returns the error messages
}
