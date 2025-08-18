using ToDoList___NetMauiTutorial.ViewModel;

namespace ToDoList___NetMauiTutorial;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}