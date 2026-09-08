Team team1 = new Team();
team1.AddPlayers();
foreach (Player i in team1.Roster){
    Console.WriteLine(i.Name);
}