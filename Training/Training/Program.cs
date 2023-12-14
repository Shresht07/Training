// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// On a standard chessboard 8 queens have to be placed so that no queen can attack any other.
// As per the rules of chess, the queen can move horizontally, vertically or in a diagonal.
// No two queens can be on the same row or column or diagonal.
// Each solution should display the Queens in 8x8 grid and print all canonical solutions
// ---------------------------------------------------------------------------------------
using System.Text;

Console.OutputEncoding = new UnicodeEncoding ();
int[] queenPlace = new int[8];
List<int[]> solution = new ();
NQueensPlacement (0);
PrintAllSolution (solution);

/// <summary>Solves the N-Queens problem using backtracking</summary>
/// <param name="queenRowPosition">The current row to place queens</param>
void NQueensPlacement (int queenRowPosition) {
   for (int i = 0; i < 8; i++) {
      if (IsQueenSafe (queenRowPosition, i)) {
         queenPlace[queenRowPosition] = i;
         if (queenRowPosition == 7) CanonicalSolutions (queenPlace.ToArray ());
         else NQueensPlacement (queenRowPosition + 1);
      }
   }
}

/// <summary>Checks if placing a queen at a given position is safe</summary>
/// <param name="row">The current row to place the queen</param>
/// <param name="column">The column to place the queen</param>
/// <returns>True if it is safe to place the queen, false otherwise</returns>
bool IsQueenSafe (int row, int column) {
   for (int prevRow = 0; prevRow <= row; prevRow++) {
      int prevCol = queenPlace[prevRow];
      if (prevCol == column || Math.Abs (prevCol - column) == row - prevRow) return false;
   }
   return true;
}

/// <summary>Displays the solutions on the chessboard</summary>
/// <param name="solution">List of all solution arrays</param>
void PrintAllSolution (List<int[]> solution) {
   int count = 1;
   foreach (int[] Sol in solution) {
      Console.CursorLeft = Console.CursorTop = 0;
      Console.WriteLine ($"Solution: {count} of {solution.Count}");
      Console.WriteLine ($"┌────┬────┬────┬────┬────┬────┬────┬────┐");
      for (int i = 0; i < 8; i++) {
         for (int j = 0; j < 8; j++) Console.Write ($"│ {(j == Sol[i] ? " ♕ " : "   "),-2}");
         Console.WriteLine ("│");
         if (i < 7) Console.WriteLine ($"├────┼────┼────┼────┼────┼────┼────┼────┤");
      }
      Console.WriteLine ($"└────┴────┴────┴────┴────┴────┴────┴────┘");
      count++;
      Console.ReadKey ();
   }
}

/// <summary>Adds a solution to the list of solutions</summary>
/// <param name="sol">Solution to be added</param>
void CanonicalSolutions (int[] sol) {
   for (int i = 0; i <= 3; i++) {
      sol = RotateSolution (sol);
      if (IsCanonical (sol) || IsCanonical (MirrorSolution (sol))) return;
   }
   solution.Add (sol);
}

// <summary>Rotates a solution by 90 degrees</summary>
/// <param name="sol">The solution to be rotated</param>
/// <returns>The rotated solution</returns>
int[] RotateSolution (int[] sol) {
   int[] arr = new int[8];
   for (int i = 0; i < arr.Length; i++) arr[sol[i]] = 8 - i - 1;
   return arr;
}

/// <summary>Mirrors a solution</summary>
/// <param name="sol">The solution to be mirrored</param>
/// <returns>The mirrored solution</returns>
int[] MirrorSolution (int[] sol) => sol.Reverse ().ToArray ();

/// <summary>Checks if a solution is identical to any of the existing solutions</summary>
/// <param name="sol">The solution to be checked for similarity</param>
/// <returns>True if the solution is identical, false otherwise</returns>
bool IsCanonical (int[] sol) => solution.Any (s => s.SequenceEqual (sol));
