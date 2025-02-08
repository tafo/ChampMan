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
