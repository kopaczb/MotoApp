using MotoApp.DataProviders;
using MotoApp.Entities;
using MotoApp.Repositories;

namespace MotoApp;

public class App : IApp
{
    private readonly IRepository<Employee> _employeesRepository;
    private readonly IRepository<Car> _carsRepository;
    private readonly ICarsProvider _carsProvider;
    public App(
        IRepository<Employee> employeesRepository,
        IRepository<Car> carsRepository,
        ICarsProvider carsProvider)
    {
        _employeesRepository = employeesRepository;
        _carsRepository = carsRepository;
        _carsProvider = carsProvider;   
    }
    public void Run()
    {
        Console.WriteLine("Example of dependency injection");

        var employees = new[]
        {
            new Employee { FirstName = "Adam"},
            new Employee { FirstName = "Piotr"},
            new Employee { FirstName = "Zuzanna"},
        };

        foreach (var employee in employees)
        {
            _employeesRepository.Add(employee);
        }

        _employeesRepository.Save();

        var items = _employeesRepository.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        var cars = GenerateSampleCars();
        foreach (var car in cars)
        { 
            _carsRepository.Add(car);
        }

        foreach (var car in _carsProvider.FilterCars(1000))
        {
            Console.WriteLine(car);
        }
    }

    public static List<Car> GenerateSampleCars()
    {
        return new List<Car>
        {
        new Car {
         Id = 680,
         Name = "Car 1",
         Color = "Black",
         StandardCost = 1059.31M,
         ListPrice = 1431.50M,
         Type = "58",
        },
         new Car {
         Id = 706,
         Name = "Car 2",
         Color = "Red",
         StandardCost = 159.31M,
         ListPrice = 131.50M,
         Type = "58",
        },
          new Car {
         Id = 706,
         Name = "Car 3",
         Color = "Yellow",
         StandardCost = 1000.31M,
         ListPrice = 1200.50M,
         Type = "58",
        },
           new Car {
         Id = 706,
         Name = "Car 4",
         Color = "Brown",
         StandardCost = 5000.31M,
         ListPrice = 5500.50M,
         Type = "58",
        },
            new Car {
         Id = 706,
         Name = "Car 5",
         Color = "Pink",
         StandardCost = 1099.31M,
         ListPrice = 1499.50M,
         Type = "58",
        },

        };
    }
}