using MotoApp.Entities;

namespace MotoApp.DataProviders;

public interface ICarsProvider
{
    List<string> GetUniqueCarColor();
    decimal GetMinimumPriceAllCars();
    //List<Car> GetSpecificColumns();
    //string AnonymousClass();
    List<Car> FilterCars(decimal minPrice);        
}