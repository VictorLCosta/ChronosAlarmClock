using CommunityToolkit.Mvvm.Input;

namespace AlarmClock.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    [RelayCommand]
    private void Clicado()
    {
        
    }
}
