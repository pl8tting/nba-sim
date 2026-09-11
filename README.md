# NBA Simulator
 
A console-based basketball simulator built with C#. Players and teams are modeled as objects with randomly generated stats, with games simulated possession by possession across an 8-team league season.
 
## What's implemented
 
- `Player` class with a name, age, and randomly generated ratings for scoring, defense, rebounding, and playmaking, along with a computed overall rating (OVR)
- `Team` class that manages a roster of players
- Possession-by-possession game simulation and scoring
- An 8-team league with randomly generated player rosters
- Double round-robin schedule, where every team plays every opponent twice
- Season standings ranked by total wins
- Season scoring leaders ranked by total points scored

## Planned Features

- Player progression and training system that adjusts ratings over time
- Player injuries
- GUI (after the console version is complete)
- Playoff and championship simulation
  
## What I Learned

- Object-oriented programming
- Organizing a project across multiple files
- Designing classes that interact with each other
- Building game and simulation logic

## How to Run

1. Clone this repository
2. Open the project in Visual Studio or another C# IDE
3. Build the project
4. Run the application

## How It Works

The simulator creates an 8-team basketball league with randomly generated player rosters and ratings.

Each team plays every other team twice in a double round-robin schedule. Games are simulated possession by possession, with the results contributing to the season standings and player scoring totals.

At the end of the season, teams are ranked by total wins and players are ranked by total points scored.

## Future Direction

The goal of this project is to continue expanding the simulator into a more complete basketball league simulation, with deeper player development, more detailed statistics, and a full playoff system.

## Requirements

- .NET
- A C# IDE such as Visual Studio or Visual Studio Code
 
## Sample output

Results vary because teams, players, and game outcomes are randomly generated.

```text
=== Season Table ===
Dallas Cavaliers: 12 Wins, 2 Losses with an 83 average Scoring
Detroit Bison: 12 Wins, 2 Losses with an 81 average Scoring
Boston Rockets: 9 Wins, 5 Losses with an 79 average Scoring
Memphis Sharks: 7 Wins, 7 Losses with an 81 average Scoring
Milwaukee Cavaliers: 5 Wins, 9 Losses with an 81 average Scoring
San Antonio Wildcats: 4 Wins, 10 Losses with an 80 average Scoring
Chicago Comets: 3 Wins, 11 Losses with an 78 average Scoring

=== Scoring Leaders ===
Jordan Young Scored 206 Points with a Scoring of 99
Kevin Harris Scored 201 Points with a Scoring of 99
James Thomas Scored 193 Points with a Scoring of 95
Marcus Lewis Scored 191 Points with a Scoring of 99
Kevin Taylor Scored 190 Points with a Scoring of 98
```
