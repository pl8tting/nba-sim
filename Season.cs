class Season
{
    public List<Team> teams = new List<Team>();
    public List<(Team TeamA, Team Teamb)> gameMatchup = new();

    public Season()
    {
        for (int i = 0; i < 8; i++)
        {
            Team team = new Team();
            team.AddPlayers();
            teams.Add(team);
        }
    }
    public void MakeSchedule()
    {
        for (int i = 0;i < teams.Count; i++)
        {
            for (int d = i + 1; d < teams.Count; d++)
            {

               gameMatchup.Add((teams[i],teams[d]));
               gameMatchup.Add((teams[d],teams[i]));
            }
        

        }
    }
    public void RunSchedule()
    {
        foreach (var matchup in gameMatchup)
        {
            Game game = new();
            game.Simulate(matchup.TeamA, matchup.Teamb);
        }
        Console.WriteLine("=== Season Table ===");
        foreach (var team in teams.OrderByDescending(team => team.Wins))
        {
            
            Console.WriteLine($"{team.Name}: {team.Wins} Wins, {team.Loss} Losses with an {team.Ovr} average Ovr");
        }
    }
    public void ScoringLeader()
    {
        var sortedList = Player.AllPlayers.OrderByDescending(player => player.Points).ToList();
        Console.WriteLine($"=== Scoring Leaders ===");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{sortedList[i].Name} Scored {sortedList[i].Points} Points with a Scoring of {sortedList[i].Scoring}");
        }
    }

}