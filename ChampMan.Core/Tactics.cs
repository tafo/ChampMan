using ChampMan.Core.Enums;

namespace DefaultNamespace;

// Tactics class that defines a team's playing style for a match
public class Tactics(Mentality mentality)
{
    public Mentality TeamMentality { get; set; } = mentality;
}
