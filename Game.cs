namespace Accentuate
{
    class Game
    {
        # region " Private Fields "
        private StringRepository _stringRepository = new StringRepository();
        private Accents _accents = new Accents();
        private QuoteList _quoteList = new QuoteList();
        private Random _random = new Random();
        private bool playWithTeams = false;
        private List<Team> teamList = new List<Team>();
        private int quoteRange;
        private int accentRange;
        # endregion

        public Game()
        {
            this.quoteRange = _quoteList.quoteList.Count;
            this.accentRange = _accents.accents.Length;
        }

        public void PlayGame()
        {
            Introduction();

            if (WantTeams())
            {
                playWithTeams = true;
                BuildTeams();
            }

            Console.WriteLine("Press enter to begin game...");
            Console.ReadLine();
            Console.WriteLine("------------------------- Game Start -------------------------");

            bool cont = true;
            int rndCnt = 1;
            while (cont)
            {
                cont = PlayRound(rndCnt);
                rndCnt += 1;
            }

            if (playWithTeams)
            {
                Console.WriteLine($"\nFINAL SCORES:\n");
                ScoreBoard();
            }

            Goodbye();
        }

        private void Introduction()
        {
            Console.WriteLine(_stringRepository.IntroText);
        }

        private bool WantTeams()
        {
            bool ask = true;
            string response = string.Empty;
            while (ask)
            {
                Console.WriteLine($"{_stringRepository.AskTeams}");
                response = Console.ReadLine() ?? "";
                switch (response)
                {
                    case "y":
                    case "Y":
                        return true;
                    case "n":
                    case "N":
                        return false;
                    default:
                        Console.WriteLine($"Invalid entry\n");
                        break;
                }
            }
            return false;
        }

        private void BuildTeams()
        {
            // How many teams?
            int total = 2;
            bool invalidTotal = true;
            string totalResponse = string.Empty;
            while (invalidTotal)
            {
                int totalResponseInt;
                Console.WriteLine("How many teams do you want?");
                totalResponse = Console.ReadLine() ?? "";
                if (Int32.TryParse(totalResponse, out totalResponseInt))
                {
                    if (totalResponseInt < 2)
                    {
                        Console.WriteLine($"Minimum 2 teams \n");
                    }
                    else if (totalResponseInt > 10)
                    {
                        Console.WriteLine($"Maximum 10 teams \n");
                    }
                    else
                    {
                        total = totalResponseInt;
                        invalidTotal = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid entry \n");
                }
            }

            // Build n teams
            for (int i = 1; i <= total; i++)
            {
                string name = "";
                bool validName = false;
                Console.WriteLine($"\nEnter name for Team {i.ToString()} (or press enter for automatic name assignment)");
                while (!validName)
                {
                    name = Console.ReadLine() ?? "";
                    if (teamList.FindIndex(team => team.teamName == name) >= 0)
                    {
                        Console.WriteLine("Team name already in list.  Please enter a new team name");
                    }
                    else
                    {
                        validName = true;
                    }
                }
                
                teamList.Add(new Team(string.IsNullOrWhiteSpace(name) ? $"Team {i.ToString()}" : name));
            }
        }

        private int Single(int round, string teamName)
        {
            Quote roundQuote = _quoteList.quoteList[_random.Next(0, quoteRange)];
            string roundAccent = _accents.accents[_random.Next(0, accentRange)];

            Console.WriteLine($"{teamName}\n");
            Console.WriteLine(_stringRepository.RoundText(roundQuote.quote, roundQuote.film, roundQuote.releaseYear, roundAccent));

            // Get the score
            bool invalidTotal = true;
            string scoreResponse = string.Empty;
            while (invalidTotal)
            {
                int scoreResponseInt;
                Console.WriteLine("Enter score obtained");
                scoreResponse = Console.ReadLine() ?? "";
                if (Int32.TryParse(scoreResponse, out scoreResponseInt))
                {
                    if (scoreResponseInt < 0 || scoreResponseInt > 3)
                    {
                        Console.WriteLine("Score must be between 0 and 3");
                    } 
                    else
                    {
                        Console.WriteLine($"{teamName} scored {scoreResponseInt.ToString()} points in round {round}\n");
                        return scoreResponseInt;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid entry \n");
                }
            }
            return 0;
        }

        private int SingleNoTeams(int round)
        {
            Quote roundQuote = _quoteList.quoteList[_random.Next(0, quoteRange)];
            string roundAccent = _accents.accents[_random.Next(0, accentRange)];

            Console.WriteLine(_stringRepository.RoundText(roundQuote.quote, roundQuote.film, roundQuote.releaseYear, roundAccent));

            return 0;
        }

        private bool PlayRound(int round) {
            Console.WriteLine($"\nRound {round.ToString()}\n");

            if (playWithTeams)
            {
                int n = playWithTeams ? teamList.Count : 1;

                for (int i = 1; i <= n; i ++)
                {
                    int score = Single(round, teamList[i - 1].teamName);
                    teamList[i - 1].score += score;
                }
                
                Console.WriteLine(_stringRepository.ContinueOrScoreBoard);
                string response = Console.ReadLine() ?? "";
                if (response == "s" || response == "S")
                {
                    var scoreBoard = new ScoreBoard(teamList);
                    scoreBoard.WriteScoreBoard();
                    Console.WriteLine($"\n\n");
                    Console.WriteLine(_stringRepository.Continue);
                    response = Console.ReadLine() ?? "";
                }
                return !(response == "x" || response == "X");
            }
            else
            {
                int score = SingleNoTeams(round);
                string response;
                Console.WriteLine(_stringRepository.Continue);
                response = Console.ReadLine() ?? "";
                
                return !(response == "x" || response == "X");
            }

            
        }

        private void ScoreBoard()
        {
            var scoreBoard = new ScoreBoard(teamList);
            scoreBoard.WriteScoreBoard();
        }

        private void Goodbye()
        {
            Console.WriteLine(_stringRepository.GoodbyeText);
            Console.ReadLine();
        }
    }
}