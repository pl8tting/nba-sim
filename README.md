# NBA Sim
 
A console-based basketball simulator using C#. Players and teams are modeled as objects with randomly generated stats, with a full game simulation engine and season loop in progress.
 
## What's implemented so far
 
- `Player` class: name, age, and position, with randomly generated ratings (scoring, defense, rebounding, playmaking) and a computed overall rating (OVR)
- `Team` class: holds a roster of players
- Random player generation 

## Planned
 
- Game simulation engine (possession-by-possession scoring)
- Season and schedule management across multiple games
- Player progression / training system that adjusts ratings over time
- GUI (after the console version is complete)

## Running it
 
```
dotnet run
```
 
## Built with
 
- C#
- .NET
