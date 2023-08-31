//Password validity checker which checks if the input password is valid or not
Console.WriteLine ("Enter a password which satisfies the following guidelines" +
   "\n1.Password must contain at least 6 characters" +
   "\n2.Pasword should start with an uppercase letter" +
   "\n3.Password must contain at least one lowercase letter" +
   "\n4.Password must contain atleast one digit" +
   "\n5.Password must contain at least one special character\n");
for (; ; ) {                                                                                          // An infinite loop to ask the user to enter a valid password 
   Console.Write ("Password: ");
   string password = Console.ReadLine ();
   var msg = StrongPassword (password);
   Console.WriteLine (msg);
   if (msg == "Accepted") break;
}                                                                                                
static string StrongPassword (string password) {
   if (password.Length < 6)                                                                           // Checks whether the input is less than 6 characters
      return "Password must contain atleast 6 characters\nInvalid password, Try again.";
   else if (!char.IsUpper (password[0]))                                                              // Checks whether the password starts with an Uppercase letter
      return "Password should start with an uppercase letter\nInvalid password, Try again.";
   else if (!password.Any (char.IsLower))                                                             // Checks whether the input has any lowercase letter in it
      return "Password must contain at least one lowercase letter\nInvalid password, Try again.";
   else if (!password.Any (char.IsDigit))                                                             // Checks whether the input has any digits in it
      return "Password must contain at least one digit\nInvalid password, Try again.";
   else if (!password.Any (char.IsSymbol) && !password.Any (char.IsPunctuation))                      // Checks whether the input has a special character in it or not
      return "Password must contain at least one special character\nInvalid password, Try again.";
   else
      return "Accepted";                                                                              // If all the conditions are met, then the method returns "Strong password"
}
