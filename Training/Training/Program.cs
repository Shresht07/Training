// --------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2023.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// Program.cs
// Program class for testing FileNameParser
// --------------------------------------------------------------------------------------------

/// <summary> Program class for testing FileNameParser</summary>
internal class Program {
   #region Methods -----------------------------------------------
   /// <summary> Entry point of the program</summary>
   static void Main (string[] args) {
      var inputs = new string[]{
         "Cz:\\abc\\def\\r.txt", "C:\\abc\\def\\r.txt", "C:\\Readme.txt", "C:\\abc\\.bcf"
         , "C:\\abc\\bcf.", "Readme.txt", "C:\\abc\\def", "C:\\abc.d", "\\abcd\\Readme.txt", " "
         , "C:\\ab.c\\def\\r.txt", "C:\\abc:d", ".\\abc", ".abc", "abc", "C:\\abc6\\def\\r.txt"
         , "C:\\abc\\def\\r.txt.txt", "C:\\work\\r.txt"
      };
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine ("Input\t\t\tResult\n");
      foreach (var input in inputs) {
         bool solution = FileNameParser.TryParseFileName (input, out _);
         Console.ForegroundColor = ConsoleColor.DarkYellow;
         Console.Write (input);
         if (!solution) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine (input.Length > 13 ? "\tFailed" : input.Length <= 5 ? "\t\t\tFailed" : "\t\tFailed");
         } else {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (input.Length > 13 ? "\tPassed" : "\t\tPassed");
         }
      }

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine ("\nDisplay of all the components in successfully parsed filename\n");
      foreach (var input in inputs) {
         var (driveLetter, folder, fileName, fileExtn) = FileNameParser.ParseFileName (input);
         if (!string.IsNullOrEmpty (driveLetter) && !string.IsNullOrEmpty (folder) && !string.IsNullOrEmpty (fileName) && !string.IsNullOrEmpty (fileExtn)) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine (input);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine ($"\nDrive letter: {driveLetter}");
            Console.WriteLine ($"Folder: {folder}");
            Console.WriteLine ($"File name: {fileName}");
            Console.WriteLine ($"File extension: {fileExtn}\n");
         }
      }
      Console.ResetColor ();
   }
   #endregion
}