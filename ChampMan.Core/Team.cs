namespace DefaultNamespace;

// Team class with dynamic Tactics per match
public class Team(string name, Tactics tactics)
{
    public string Name { get; } = name;
    public Tactics CurrentTactics { get; set; } = tactics; // Tactics now belong to the team dynamically
}
