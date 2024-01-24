string[] gameArr = File.ReadAllLines ("C:\\etc\\input.txt");
int ProgramOne (string game) {
   int blueCubeScore = 0;
   int redCubeScore = 0;
   int greenCubeScore = 0;
   string[] singleGame = game.Split ();
   int gameID = int.Parse (singleGame[1].Replace (":", ""));
   for (int i = 1; i < singleGame.Length - 1;) {
      if (singleGame[i].ToLower ().Contains ("blue")) {
         blueCubeScore += int.Parse (singleGame[i - 1]);
         i++;
      } else if (singleGame[i].ToLower ().Contains ("red")) {
         redCubeScore += int.Parse (singleGame[i - 1]);
         i++;
      } else if (singleGame[i].ToLower ().Contains ("green")) {
         greenCubeScore += int.Parse (singleGame[i - 1]);
         i++;
      } else {
         i++;
         continue;
      }
   }
   if (redCubeScore <= 12 && greenCubeScore <= 13 && blueCubeScore <= 14) return gameID;
   else return 0;
}

foreach(var game in gameArr) {
   int result = 0;
   result += ProgramOne (game);
   Console.WriteLine (result);
}