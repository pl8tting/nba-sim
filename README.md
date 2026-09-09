# NBA Sim
 
A console-based basketball simulator using C#. Players and teams are modeled as objects with randomly generated stats, with a full game simulation engine and season loop in progress.
 
## What's implemented so far
 
- `Player` class: name and age, with randomly generated ratings (scoring, defense, rebounding, playmaking) and a computed overall rating (OVR)
- `Team` class: holds a roster of players
- possession-by-possession scoring
- An 8-team league with randomly generated rosters
- Double round-robin scheduling, where every team plays every opponent twice
- Season standings sorted by wins
- Season scoring leaders based on total points scored

## Planned

- Season and schedule management across multiple games
- Player progression / training system that adjusts ratings over time
- GUI (after the console version is complete)

## Running it
 
```
dotnet run
```
 
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
## Built with
 
- C#
- .NET
