using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChampMan.Core.Enums;
using ChampMan.UI.ViewModels;
using DefaultNamespace;

namespace ChampMan.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly MatchEngineViewModel _matchEngineViewModel;
    
    public MainWindow()
    {
        InitializeComponent();
        _matchEngineViewModel = new MatchEngineViewModel(
            new Team("Home FC", new Tactics(Mentality.Attacking)),
            new Team("Away United", new Tactics(Mentality.Defensive))
        );

        DataContext = _matchEngineViewModel; // Set the ViewModel as the DataContext
    }
    
    private void StartMatch_Click(object sender, RoutedEventArgs e)
    {
        _matchEngineViewModel.StartMatch();
    }
}