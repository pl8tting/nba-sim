class Game{
    public Random rng = new Random();
    // Simulate game method, taking two teams

    //avg posessions in an nba game is 95 - 100 per team, so 200 total
    int totalPossesions = 200;
    public void Simulate(Team teama, Team teamb){
        int teamPointsA = 0;
        int teamPointsB = 0;
        int possesion = 0;
        for (int f = 0;f<totalPossesions; f++){
            if (possesion == 0){
                double playerChoice = rng.NextDouble() * teama.Weight;
                double tempCheck = 0;
                foreach (Player i in teama.Roster){
                    tempCheck += i.weight;
                
                    if (tempCheck >= playerChoice) {
                        if (rng.NextDouble() <= i.fg){
                            Console.WriteLine($"{i.Name} Scored!");
                            int twoOrThree = rng.Next(2,4);
                            i.Scored(twoOrThree);
                            teamPointsA += twoOrThree;

                        }
                        else{
                            Console.WriteLine($"{i.Name} Missed.");
                        }
                        break;
                    }

                }
            }
            else
            {
            double tempCheck = 0;
            double playerChoice = rng.NextDouble() * teamb.Weight;
            foreach (Player i in teamb.Roster){
                tempCheck += i.weight;         
                if (tempCheck >= playerChoice) {
                    if (rng.NextDouble() <= i.fg){
                        Console.WriteLine($"{i.Name} Scored!");
                        int twoOrThree = rng.Next(2,4);
                        i.Scored(twoOrThree);
                        teamPointsB += twoOrThree;
                        }

                    else{
                        Console.WriteLine($"{i.Name} Missed.");
                        }
                    break;
                    }

                }
            }
            possesion = 1 - possesion;
        }
        Console.WriteLine($"{teama.Name} - {teamb.Name}: {teamPointsA} - {teamPointsB}");
    }


}
