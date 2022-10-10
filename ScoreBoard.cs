namespace Accentuate
{
    class ScoreBoard
    {
        List<Team> teams;
        public ScoreBoard(List<Team> teams)
        {
            this.teams = teams;
        }

        public void WriteScoreBoard()
        {
            Console.Write("|");
            foreach (Team team in teams)
            {
                Console.Write($" {team.teamName} |");
            }
            Console.WriteLine();
            
            for(int i = 1; i <= TableWidth(); i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.Write("|");
            foreach (Team team in teams)
            {
                double l = team.teamName.Length / 2;
                for(int i = 0; i < Math.Round(l); i ++)
                {
                    Console.Write(" ");
                }
                Console.Write($" {team.score.ToString()}");
                for(int i = 0; i < Math.Round(l); i ++)
                {
                    Console.Write(" ");
                }
                Console.Write(" |");
            }
        }

        private int TableWidth()
        {
            // Seperators
            int width = 2 + (teams.Count * 2);
            // Team names
            foreach (Team team in teams)
            {
                width += team.teamName.Length;
            }
            return width;
        }
    }
}