namespace DefaultNamespace;

using System;
using ChampMan.Core.Enums;
using System.Collections.ObjectModel;
using System.Windows.Threading;

public class MatchEngine
{
    private int _matchTime = 0;
    private readonly Random _random = new Random();
    private readonly Team _homeTeam;
    private readonly Team _awayTeam;
    private Team _possessionTeam;
    private readonly DispatcherTimer _matchTimer;

    public ObservableCollection<string> MatchEvents { get; set; } = [];

    public MatchEngine(Team home, Team away)
    {
        _homeTeam = home;
        _awayTeam = away;
        _possessionTeam = home; // Start with home team in possession

        _matchTimer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1) // Simulating 1 minute per second
        };
        _matchTimer.Tick += ProcessMatchEvent;
    }

    public void StartMatch()
    {
        MatchEvents.Add($"🏆 The match between {_homeTeam.Name} and {_awayTeam.Name} has started!");
        _matchTimer.Start();
    }

    private void ProcessMatchEvent(object? sender, EventArgs e)
    {
        if (_matchTime >= 90)
        {
            _matchTimer.Stop();
            MatchEvents.Add("📢 The final whistle blows! The match is over.");
            return;
        }

        _matchTime++;
        var eventChance = _random.Next(0, 100);

        // ToDo: This will be updated !!!
        if (eventChance >= 40) return; // 40% chance of an important event
        var eventType = DetermineEventType(_possessionTeam.CurrentTactics.TeamMentality);

        var eventMessage = eventType switch
        {
            0 => "The team is controlling possession in midfield.",
            1 => "A striker takes a powerful shot!",
            2 => "A defender makes a crucial tackle!",
            _ => "A moment of brilliance on the field!"
        };

        MatchEvents.Add($"{_matchTime}' - {_possessionTeam.Name}: {eventMessage}");

        if (_random.Next(0, 100) < 50) // 50% chance to switch possession
        {
            _possessionTeam = (_possessionTeam == _homeTeam) ? _awayTeam : _homeTeam;
        }
    }

    private int DetermineEventType(Mentality mentality)
    {
        return mentality switch
        {
            Mentality.Attacking => _random.Next(0, 2), // More possession and shooting events
            Mentality.Normal => _random.Next(0, 3), // Balanced event selection
            Mentality.Defensive => _random.Next(1, 3), // More defensive and tackling events
            _ => _random.Next(0, 3)
        };
    }
}
