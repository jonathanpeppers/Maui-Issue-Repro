using CollectionViewPerformanceReproMaui.ViewModels;

namespace CollectionViewPerformanceReproMaui.Views;

public partial class DataView : ContentPage
{
	public DataView(DataViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		_ = ((DataViewModel)this.BindingContext).InitialiseAsync();
	}
}