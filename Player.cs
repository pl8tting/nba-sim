class Player
    {
        public string[] firstNames = {
        "James", "Michael", "Chris", "Anthony", "Kevin", "Jordan", "Marcus",
        "Devin", "Trevor", "Malik", "Isaiah", "Andre", "Tyler", "Jalen",
        "Xavier", "Elijah", "Dominic", "Cameron", "Brandon", "Terrence"
        };
        
        string[] lastNames = {
            "Johnson", "Williams", "Brown", "Davis", "Miller", "Wilson", "Moore",
            "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Clark",
            "Lewis", "Walker", "Young", "Allen", "Robinson", "Carter"
        };

        public Random rng = new Random();
        public string Name;

        public int Points = 0;
        public int Age;
        public int Scoring;
        public int Defense;
        public int Rebounding;
        public int Playmaking;
        public int id;
        public int Ovr;
        public double weight;
        public static int nextId;
        public double fg;

        public Player()
        {
            Age = rng.Next(18,42);
            Name = $"{firstNames[rng.Next(firstNames.Length)]} {lastNames[rng.Next(lastNames.Length)]}";
            Scoring = rng.Next(60, 100);  
            Defense = rng.Next(60, 100);  
            Rebounding = rng.Next(60, 100);  
            Playmaking = rng.Next(60, 100);  
            id = nextId;
            nextId++;
            Ovr = (Scoring + Defense + Rebounding + Playmaking) / 4;
            // Scoring weighted heavier than Playmaking. scorers should be
            // picked to shoot more often than playmakers, but playmakers
            // still get a boost
            weight = (Scoring * 0.8 + Playmaking * 0.2);
            // determining fg%
            // seeing how far along the range of 60 - 99 it is
            fg = (Scoring - 60) / (99.0 - 60);
            // the range is from 0.20 (20%) to 0.65 (65%) i.e 0.45
            // so this sees how far along they are along this range
            fg = (fg * 0.45 );
            // then to get an actual point add this to the floor to get an actual point
            fg += 0.2;
        }
    
        public void Scored(int points)
    {
        Points += points;
    }

    }