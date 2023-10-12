using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		var person = new Person 
		{
		Name = "Hector",
		Age = 50
		};
		BindingContext = person;
	}
}