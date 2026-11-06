using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Anime.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] public partial string Greeting { get; set; } = "Welcome to Avalonia!";
    public ObservableCollection<Anime> Catalogo {get; set;}
    public Anime AnimeSelezionato { get; set; }

    public MainViewModel()
    {
        Catalogo = new ObservableCollection<Anime>()
    }
}