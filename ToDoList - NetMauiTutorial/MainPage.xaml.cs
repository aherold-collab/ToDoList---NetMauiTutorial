using ToDoList___NetMauiTutorial.ViewModel;

namespace ToDoList___NetMauiTutorial;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
