namespace Accentuate
{
    public class Team
    {
        public string teamName { get; set; }
        public int score { get; set; }
        public Team(string name)
        {
            this.teamName = name;
        }
    }
}