using MotoApp.Entities;
using MotoApp.Repositories;
using System.Net.Http.Headers;

namespace MotoApp.DataProviders;

public class CarProviderBasic : ICarsProvider
{
    private readonly IRepository<Car> _carsRepository;
    public CarProviderBasic(IRepository<Car> carsRepository)
    {
        _carsRepository = carsRepository;
    }
    public List<Car> FilterCars(decimal minPrice)
    {
        var cars = _carsRepository.GetAll();
        var list = new List<Car>();

        foreach (var car in cars)
        {
            if (car.ListPrice > minPrice)
            { 
                list.Add(car);
            }
        }

        return list;
    }

    public decimal GetMinimumPriceAllCars()
    {
        var cars = _carsRepository.GetAll();
        decimal ret = decimal.MinValue;

        foreach (var car in cars)
        {
            if (car.ListPrice < ret)
            { 
                ret = car.ListPrice;
            }
        }

        return ret;
    }

    public List<string> GetUniqueCarColor()
    {
        var cars = _carsRepository.GetAll();
        List<string> list = new();

        foreach (var car in cars)
        {
            if (!list.Contains(car.Color))
            {
                list.Add(car.Color);
            }
        }

        return list;
    }
}