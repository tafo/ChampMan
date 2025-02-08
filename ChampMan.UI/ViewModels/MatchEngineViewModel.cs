using DefaultNamespace;

namespace ChampMan.UI.ViewModels;

using System.Collections.ObjectModel;
using System.ComponentModel;

public class MatchEngineViewModel : INotifyPropertyChanged
{
    private readonly MatchEngine _matchEngine;

    public ObservableCollection<string> MatchEvents { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    public MatchEngineViewModel(Team home, Team away)
    {
        _matchEngine = new MatchEngine(home, away);
        MatchEvents = _matchEngine.MatchEvents;
    }

    public void StartMatch()
    {
        _matchEngine.StartMatch();
    }
}
