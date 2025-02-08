🏆 ChampMan

ChampMan is a Windows-based, text-based desktop football management simulation. This application aims to provide a unique football management experience by displaying match flow using text instead of graphical representations.

🚀 Features

⚽ Text-Based Match Simulation: The match flow will be presented through event-based text descriptions.

📜 ListBox & Rich Text Support: Match events will be displayed in detailed and formatted text.

🖥 Windows Compatible: Developed using .NET Core and Rider IDE.

🏗 Modular Architecture: Designed with a clean and extensible structure for easy expansion.

📂 Installation

Follow these steps to run the project:

```csharp
# Clone the repository
git clone https://github.com/username/champman.git

# Navigate to the project directory
cd champman

# Restore .NET dependencies
dotnet restore

# Run the application
dotnet run
```

🔧 Requirements

To run ChampMan, you need the following:

- Windows 10 or later[/list]
- .NET 6+ SDK
- IDE (Rider Recommended)

🏗 Architecture

The project follows SOLID principles and is divided into the following main components:


- MatchEngine: Manages match events and flow.
- UI Module: Displays match results and events using ListBox or rich text format.
- Team & Player Management: Handles team and player data.

🏆 Usage

Select Your Team: Choose a team to start your managerial career.

Manage Matches: Monitor player performance and develop tactics.

Win the League: Make the right transfers and strategies to become the best team!

📜 Contributing

If you would like to contribute to the project, follow these steps:

- Fork: Fork the repository to your GitHub account.
- Create a Branch: Open a new branch for a feature or bug fix.
- Commit Your Changes: Save your changes with meaningful commit messages.
- Submit a Pull Request: Open a PR to merge your changes into the main project.

🚀 Start your football management journey with ChampMan and dominate the field! ⚽

🏆 Gameplay Mechanics

Player Attributes & Match Impact

Each player has a set of attributes rated on a 0-20 scale, where:

0 = Very Poor

10 = Average

20 = Elite Level

These attributes influence match performance in various ways:

⚽ Attacking Events

| Event              | Affected Attributes                  | Description                               |
|-------------------|--------------------------------|---------------------------------|
| Shooting          | Finishing, Technique, Composure | Determines shot accuracy and efficiency. |
| Dribbling         | Dribbling, Agility, Flair       | Ability to beat defenders with skill moves. |
| Crossing         | Crossing, Technique, Vision     | Quality of crosses into the box. |
| Shot Saving (GK) | Reflexes, Handling, Positioning | How well a goalkeeper reacts to shots. |
| Passing          | Passing, Vision, Technique      | Accuracy of short and long passes. |
| Free Kicks       | Set Pieces, Technique, Finishing | Effectiveness in dead-ball situations. |
| Off-the-Ball Movement | Off The Ball, Acceleration, Pace | Ability to find spaces and make runs. |

🛡️ Defensive Events

| Event         | Affected Attributes               | Description                               |
|-------------|--------------------------------|---------------------------------|
| Tackling     | Tackling, Aggression, Strength  | Success in winning the ball back. |
| Marking      | Marking, Positioning, Concentration | Ability to track and restrict opponents. |
| Aerial Duels | Jumping, Heading, Strength      | Performance in heading challenges. |
| Pressing     | Work Rate, Aggression, Stamina  | How effectively a player applies pressure. |

📌 General Match Mechanics

| Event                   | Affected Attributes                  | Description                                |
|------------------------|--------------------------------|--------------------------------|
| Fatigue & Performance Drop | Stamina, Injury Resistance   | Players tire as the match progresses. |
| Critical Decision Making  | Decisions, Composure, Leadership | Ability to make the right choices under pressure. |
| Team Leadership         | Leadership, Influence, Teamwork  | Motivating and organizing teammates. |

🏆 Key Match Events

In ChampMan, only significant moments of a match will be displayed. Routine midfield battles and uneventful periods will be skipped.

⚽ Dynamic Match Events & Tactical Influence

Match event probabilities are dynamic and change based on team tactics and player instructions. The way teams play directly affects which events occur more frequently.

📌 Tactical Adjustments & Their Impact on Match Events

| Tactical Choice  | Affected Events                                    | Effect |
|-----------------|------------------------------------------------|---------|
| Attacking      | More Shots, More Counterattacks, Less Defensive Actions | Increases shot attempts and attacking events, but leaves the defense vulnerable. |
| Defensive      | More Tackles, More Interceptions, Fewer Shots    | Increases defensive actions but limits attacking opportunities. |
| Aggressive     | More Fouls, More Cards, More Injuries            | Higher foul and booking probability, increasing physical battles. |
| Possession     | More Passing Events, Fewer Long Balls, Lower Counterattacks | More ball control but fewer direct attacking chances. |
| High Pressing  | More Tackles, More Stamina Drain, Higher Risk of Mistakes | More defensive pressure but increases player fatigue. |
| Low Block      | Less Pressing, More Defenders Behind the Ball    | Reduces opponent’s chances but lowers counter-attacking potential. |

⚽ Dynamic Match Probability Calculations

Probabilities are calculated based on the team’s chosen playstyle.

Example Scenarios:

If both teams play aggressively:

Foul & Card probability increases.

More free kicks and penalties occur.

If one team plays attacking while the other defends deeply:

The attacking team will have more shots.

The defending team will have more chances to win possession and counterattack.

📜 Example Match Flow (Tactic-Based Probabilities)

```
12' - The home team is pressing high! The away team struggles to keep possession.
27' - Hard tackle! The referee reaches into his pocket... Yellow card!
42' - Long pass to the winger, he cuts inside... takes a shot! Blocked by the defender!
56' - The away team is sitting deep, defending with numbers. Can they hold on?
78' - Quick counterattack! The striker is through on goal… GOAL! 1-0!
```

🚀 ChampMan dynamically adjusts match events based on tactical choices, making every match unique and exciting! ⚽
