using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DefaultNamespace;

namespace Anime.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public ObservableCollection<global::Anime> Catalog { get; }

    [ObservableProperty]
    private global::Anime? selectedAnime;

    public MainViewModel()
    {
        Catalog = new ObservableCollection<global::Anime>(CatalogManager.Istanza.AnimeDisponibili);
    }
}