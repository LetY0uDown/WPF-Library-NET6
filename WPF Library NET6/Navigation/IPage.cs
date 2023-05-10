using System.Threading.Tasks;

namespace WPFLibrary.Navigation;

public interface IPage
{
    ViewModel ViewModel { get; }

    Task Display ();

    Task Leave ();
}