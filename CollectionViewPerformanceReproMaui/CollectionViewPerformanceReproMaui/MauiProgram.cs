using CollectionViewPerformanceReproMaui.Services;
using CollectionViewPerformanceReproMaui.ViewModels;
using CollectionViewPerformanceReproMaui.Views;

namespace CollectionViewPerformanceReproMaui
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				})
				.RegisterServices()
				.RegisterViewModels()
				.RegisterViews();

			return builder.Build();
		}

		public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
		{
			mauiAppBuilder.Services.AddSingleton<IDataService, DataService>();

			return mauiAppBuilder;
		}

		public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
		{
			mauiAppBuilder.Services.AddSingleton<DataViewModel>();

			return mauiAppBuilder;
		}

		public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
		{
			mauiAppBuilder.Services.AddSingleton<DataView>();

			return mauiAppBuilder;
		}
	}
}
