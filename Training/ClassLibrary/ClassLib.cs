using static State;
public class FileNameParser {
   public static (string driveLetter, string folder, string fileName, string fileExtn) ParseFileName (string input) {
      string driveLetter = string.Empty, folder = string.Empty, fileName = string.Empty, fileExtn = string.Empty, temp = string.Empty;
      State currentState = A;
      Action none = () => { };
      Action toDo;
      string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      foreach (var ch in input.ToUpper ().Trim () + "|") {
         (currentState, toDo) = (currentState, ch) switch {
            (A, >= 'A' and <= 'Z') => (B, () => driveLetter += ch),
            (B, ':') => (C, none),
            (C, '\\') => (D, none),
            (D, _) when alphabets.Contains (ch) => (D, () => folder += ch),
            (D, '\\') => (E, none),
            (E, _) when alphabets.Contains (ch) => (E, () => temp += ch),
            (E, '\\') => (F, () => { folder += '\\' + temp; temp = string.Empty; }),
            (D or F, _) when alphabets.Contains (ch) => (F, () => fileName += ch),
            (E or F, '.') => (G, () => fileName += temp),
            (G, _) when alphabets.Contains (ch) => (G, () => fileExtn += ch),
            (G, '|') => (H, none),
            _ => (Z, none)
         };
         toDo ();
      }
      return (currentState is H) ? (driveLetter, folder, fileName, fileExtn) : (string.Empty, string.Empty, string.Empty, string.Empty);
   }
   public static bool TryParseFileName (string input, out (string driveLetter, string folder, string fileName, string fileExtn) result) {
      result = ParseFileName (input);
      if (string.IsNullOrEmpty (result.driveLetter) || string.IsNullOrEmpty (result.folder) || string.IsNullOrEmpty (result.fileName) || string.IsNullOrEmpty (result.fileExtn)) return false;
      return true;
   }
}
enum State { A, B, C, D, E, F, G, H, Z };