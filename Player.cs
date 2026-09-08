class Player
{
    public string[] FirstNames = {
        "James", "Michael", "Chris", "Anthony", "Kevin", "Jordan", "Marcus",
        "Devin", "Trevor", "Malik", "Isaiah", "Andre", "Tyler", "Jalen",
        "Xavier", "Elijah", "Dominic", "Cameron", "Brandon", "Terrence"
    };

    string[] lastNames = {
        "Johnson", "Williams", "Brown", "Davis", "Miller", "Wilson", "Moore",
        "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Clark",
        "Lewis", "Walker", "Young", "Allen", "Robinson", "Carter"
    };

    public Random Rng = new Random();
    public string Name;
    public int Points = 0;
    public int Age;
    public int Scoring;
    public int Defense;
    public int Rebounding;
    public int Playmaking;
    public int Id;
    public int Ovr;
    public double Weight;
    public static int NextId;
    public double Fg;

    public Player()
    {
        Age = Rng.Next(18, 42);
        Name = $"{FirstNames[Rng.Next(FirstNames.Length)]} {lastNames[Rng.Next(lastNames.Length)]}";
        Scoring = Rng.Next(60, 100);
        Defense = Rng.Next(60, 100);
        Rebounding = Rng.Next(60, 100);
        Playmaking = Rng.Next(60, 100);
        Id = NextId;
        NextId++;
        Ovr = (Scoring + Defense + Rebounding + Playmaking) / 4;
        // Scoring weighted heavier than Playmaking. scorers should be
        // picked to shoot more often than playmakers, but playmakers
        // still get a boost
        Weight = (Scoring * 0.8 + Playmaking * 0.2);
        // determining fg%
        // seeing how far along the range of 60 - 99 it is
        Fg = (Scoring - 60) / (99.0 - 60);
        // the range is from 0.20 (20%) to 0.65 (65%) i.e 0.45
        // so this sees how far along they are along this range
        Fg = (Fg * 0.45);
        // then to get an actual point add this to the floor to get an actual point
        Fg += 0.2;
    }

    public void Scored(int points)
    {
        Points += points;
    }
}