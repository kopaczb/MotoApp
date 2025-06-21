using MotoApp.Entities;
using MotoApp.Repositories;

namespace MotoApp.DataProviders;

public class CarsProvider : ICarsProvider
{

    private readonly IRepository<Car> _carsRepository;
    public CarsProvider(IRepository<Car> carsRepository)
    {
        _carsRepository = carsRepository;
    }
    public List<Car> FilterCars(decimal minPrice)
    {
        var cars = _carsRepository.GetAll();
        var list = new List<Car>();

        foreach (var car in cars) 
        {
            if (car.ListPrice < minPrice) 
            {
                list.Add(car);
            }
        }

        return list;
    } 

    public decimal GetMinimumPriceAllCars()
    {
        throw new NotImplementedException();
    }

    public List<string> GetUniqueCarColor()
    {
        throw new NotImplementedException();
    }
}