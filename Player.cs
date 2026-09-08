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
        public int Age;
        public int Scoring;
        public int Defense;
        public int Rebounding;
        public int Playmaking;
        public int id;
        public int Ovr;
        public static int nextId;

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
        }

    }