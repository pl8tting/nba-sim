class Game
{
    Dictionary<Player, int> gamePoints = new Dictionary<Player, int>();
    public Random Rng = new Random();
    int totalPossesions = 200;

    public void BoxScore(Team team)
    {
        Console.WriteLine($"--- {team.Name} ---");
        var sortedRoster = team.Roster.OrderByDescending(p => gamePoints[p]);
        foreach (Player p in sortedRoster)
        {
            Console.WriteLine($"{p.Name} — {gamePoints[p]} pts (Scoring: {p.Scoring})");
        }
    }

    public void Simulate(Team teama, Team teamb)
    {
        foreach (Player p in teama.Roster) { gamePoints[p] = 0; }
        foreach (Player p in teamb.Roster) { gamePoints[p] = 0; }

        int teamPointsA = 0;
        int teamPointsB = 0;
        int possesion = 0;
        double diff = 0;
        // Defense can shift shot chance by about 30%
        double maxSwing = 0.3;

        for (int f = 0; f < totalPossesions; f++)
        {
            if (possesion == 0)
            {
                double playerChoice = Rng.NextDouble() * teama.Weight;
                double tempCheck = 0;
                foreach (Player i in teama.Roster)
                {
                    tempCheck += i.Weight;
                    if (tempCheck >= playerChoice)
                    {
                        diff = i.Scoring - teamb.Defense;
                        // max difference is +- 39 (99 - 60) so this just gets a fraction of it
                        diff = diff / 39.0;
                        //
                        diff = (maxSwing * diff);
                        double AdjustedFg = i.Fg + diff;
                        int twoOrThree = Rng.Next(2, 4);
                        i.Scored(twoOrThree);
                        AdjustedFg = Math.Clamp(AdjustedFg, 0.10, 0.65);
                        if (Rng.NextDouble() <= AdjustedFg)
                        {
                            
                            teamPointsA += twoOrThree;
                            gamePoints[i] += twoOrThree;
                        }
                        break;
                    }
                }
            }
            else
            {
                double tempCheck = 0;
                double playerChoice = Rng.NextDouble() * teamb.Weight;
                foreach (Player i in teamb.Roster)
                {
                    tempCheck += i.Weight;
                    if (tempCheck >= playerChoice)
                    {
                        diff = i.Scoring - teama.Defense;
                        diff = diff / 39.0;
                        diff = (maxSwing * diff);
                        double AdjustedFg = i.Fg + diff;
                        int twoOrThree = Rng.Next(2, 4);
                        i.Scored(twoOrThree);
                        AdjustedFg = Math.Clamp(AdjustedFg, 0.10, 0.65);
                        if (Rng.NextDouble() <= AdjustedFg)
                        {
                            teamPointsB += twoOrThree;
                            gamePoints[i] += twoOrThree;
                        }
                        break;
                    }
                }
            }
            possesion = 1 - possesion;
        }
        if (teamPointsA > teamPointsB)
        {
            teama.Wins++;
            teamb.Loss++;
        }
        else
        {
            teama.Loss++;
            teamb.Wins++;
        }
    }
}
