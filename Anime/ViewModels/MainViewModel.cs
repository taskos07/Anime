using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DefaultNamespace;

namespace Anime.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public ObservableCollection<DefaultNamespace.Anime> Catalog { get; }

    [ObservableProperty]
    private DefaultNamespace.Anime? selectedAnime;

    public MainViewModel()
    {
        Catalog = new ObservableCollection<DefaultNamespace.Anime>(CatalogManager.Istanza.AnimeDisponibili);
    }
}