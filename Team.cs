class Team
{
    public int Wins = 0;
    public int Loss = 0;
    public Random Rng = new Random();

    string[] cities = {
        "Atlanta", "Boston", "Chicago", "Dallas", "Denver", "Detroit",
        "Houston", "Miami", "Milwaukee", "Minnesota", "Orlando", "Phoenix",
        "Portland", "Sacramento", "San Antonio", "Toronto", "Utah",
        "Memphis", "Charlotte", "Indiana"
    };

    string[] nicknames = {
        "Cavaliers", "Hawks", "Titans", "Comets", "Blazers", "Raptors",
        "Wolves", "Kings", "Storm", "Aces", "Rockets", "Suns",
        "Riders", "Wildcats", "Vipers", "Knights", "Rebels",
        "Sharks", "Bison", "Miners"
    };

    public string Name;
    public int Ovr;
    public List<Player> Roster;
    public string City;
    public double Weight = 0;
    public double Defense;

    public Team()
    {
        Defense = 0;
        City = $"{cities[Rng.Next(cities.Length)]}";
        Name = $"{City} {nicknames[Rng.Next(nicknames.Length)]}";
        Ovr = 0;
        Roster = new List<Player>();
    }

    public void AddPlayer(Player player)
    {
        Roster.Add(player);
        Weight += player.Weight;
        Ovr = 0;
        Defense = 0;
        foreach (var i in Roster)
        {
            Ovr += i.Ovr;
            Defense += i.Defense;
        }
        Ovr = Ovr / Roster.Count;
        Defense = Defense / Roster.Count;
        Player.AllPlayers.Add(player);
    }

    public void AddPlayers()
    {
        for (int i = 0; i < 15; i++)
        {
            Player player = new Player();
            Roster.Add(player);
            Weight += player.Weight;
            Player.AllPlayers.Add(player);
        }
        Defense = 0;
        Ovr = 0;
        foreach (var i in Roster)
        {
            Ovr += i.Ovr;
            Defense += i.Defense;
        }
        Ovr = Ovr / Roster.Count();
        Defense = Defense / Roster.Count();
    }
}