using CollectionViewPerformanceReproMaui.Models;

namespace CollectionViewPerformanceReproMaui.Services
{
	public interface IDataService
	{
		Task<List<Data>> GetData();
	}
}
