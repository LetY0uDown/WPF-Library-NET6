using System.Threading.Tasks;

namespace WPFLibrary.Navigation;

public interface INavigation
{
    IPageFactory PageFactory { get; }

    INavigationViewModel NavigationModel { get; }

    Task DisplayPage<T> (params (string Title, object Value)[] parameters) where T : IPage;

    Task DisplayPage<T> () where T : IPage;

    Task DisplayNext ();

    Task DisplayPrevious ();
}