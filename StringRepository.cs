namespace Accentuate
{
    public class StringRepository
    {
        public string IntroText = @"
                            WELCOME TO ACCENTUATE
            ======================================================
                                    RULES 
SPLIT INTO TEAMS, ANY NUMBER OF TEAMS WORKS AS LONG AS THERE ARE AT LEAST TWO PLAYERS PER TEAM
                    YOU MAY NOT MANIPULATE THE QUOTE\n\
                YOU MAY IMITATE MANNERISM BUT NOT USE ACTIONS\n\
            ======================================================\
            ";

        public string AskTeams = @"
                        WOULD YOU LIKE TO KEEP SCORE?
                              INPUT 'Y' FOR YES
                              INPUT 'N' FOR NO
            ";

        public string RoundText(string quote, string film, int year, string accent)
        {
            return $"Quote: {quote}\nFilm: {film}\nYear: {year.ToString()}\nAccent: {accent}";
        }

        public string Continue = @"
            PRESS ENTER FOR NEW ROUND
                INPUT X TO EXIT
            ";

        public string ContinueOrScoreBoard = @"
            PRESS ENTER FOR NEW ROUND
            INPUT S TO SEE SCOREBOARD
                INPUT X TO EXIT
            ";

        public string GoodbyeText = @"
            THANKS FOR PLAYING ACCENTUATE
                    GOODBYE
            ";
    }
}