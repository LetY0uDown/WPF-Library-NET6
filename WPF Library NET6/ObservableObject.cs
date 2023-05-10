using System.ComponentModel;

namespace WPFLibrary;

public abstract class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
}