using System.Threading.Tasks;

namespace WPFLibrary.Navigation;

public abstract class ViewModel : ObservableObject
{
    public abstract Task Initialize ();

    public abstract Task Disable ();
}