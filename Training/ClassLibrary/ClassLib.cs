// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2023.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// Classlib.cs
// Program that parses file paths and extracts data, including the file name, extension,
// drive letter, and folder.
// ------------------------------------------------------------------------------------------------
using static State;
/// <summary>Provides method for interpreting file paths and retrieving data, including 
/// file name, extension, drive letter, and folder </summary>
#region FileNameParser -------------------------------------------
public class FileNameParser {
   #region Methods -----------------------------------------------
   /// <summary>Represents the various stages that occur 
   /// during the parsing procedure </summary>
   /// See File://
   public static (string driveLetter, string folder, string fileName, string fileExtn) ParseFileName (string input) {
      string driveLetter = string.Empty, folder = string.Empty, fileName = string.Empty, fileExtn = string.Empty, temp = string.Empty;
      State currentState = A;
      Action none = () => { };
      Action toDo;
      foreach (var ch in input.ToUpper ().Trim () + "|") {
         (currentState, toDo) = (currentState, ch) switch {
            (A, >= 'A' and <= 'Z') => (B, () => driveLetter += ch),
            (B, ':') => (C, none),
            (C, '\\') => (D, none),
            (D, >= 'A' and <= 'Z') => (D, () => folder += ch),
            (D, '\\') => (E, none),
            (E, >= 'A' and <= 'Z') => (E, () => temp += ch),
            (E, '\\') => (F, () => { folder += '\\' + temp; temp = string.Empty; }),
            (D or F, >= 'A' and <= 'Z') => (F, () => fileName += ch),
            (E or F, '.') => (G, () => fileName += temp),
            (G, >= 'A' and <= 'Z') => (G, () => fileExtn += ch),
            (G, '|') => (H, none),
            _ => (Z, none)
         };
         toDo ();
      }
      return (currentState is H) ? (driveLetter, folder, fileName, fileExtn) : (string.Empty, string.Empty, string.Empty, string.Empty);
   }

   /// <summary>Returns true or false based on the parsed name</summary>
   /// <param name="input"></param>
   /// <param name="result"></param>
   /// <returns>True if successfully parsed</returns>
   public static bool TryParseFileName (string input, out (string driveLetter, string folder, string fileName, string fileExtn) result) {
      result = ParseFileName (input);
      if (string.IsNullOrEmpty (result.driveLetter) || string.IsNullOrEmpty (result.folder) || string.IsNullOrEmpty (result.fileName) || string.IsNullOrEmpty (result.fileExtn)) return false;
      return true;
   }
   #endregion
}
#endregion
enum State { A, B, C, D, E, F, G, H, Z };