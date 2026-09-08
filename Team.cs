class Team{

    public Random rng = new Random();

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

    public Team(){
        City = $"{cities[rng.Next(cities.Length)]}";
        Name = $"{City} {nicknames[rng.Next(nicknames.Length)]}";
        Ovr = 0;
        Roster = new List<Player>();

    }
    public void AddPlayer(Player player){
        Roster.Add(player);
    }
    public void AddPlayers(){
        for (int i=0;i<=15;i++){
            Player player = new Player();
            Roster.Add(player);
        }
    }
}