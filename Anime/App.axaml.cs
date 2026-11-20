using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Anime.ViewModels;
using Anime.Views;
using DefaultNamespace;

namespace Anime;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
#if DEBUG
        this.AttachDeveloperTools();
#endif
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (CatalogManager.Istanza.AnimeDisponibili.Count == 0)
        {
            AnimeMovie.FactoryMovie("film-1", "Il mio vicino Totoro", 8.5f, 1988, 86);
            AnimeSeries.FactorySeries("serie-1", "Fullmetal Alchemist: Brotherhood", 9.1f, 2009, 1);
            AnimeSeries.FactorySeries("serie-2", "Demon Slayer", 8.7f, 2019, 4);
        }

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }
        else if (ApplicationLifetime is IActivityApplicationLifetime singleViewFactoryApplicationLifetime)
        {
            singleViewFactoryApplicationLifetime.MainViewFactory =
                () => new MainView { DataContext = new MainViewModel() };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}