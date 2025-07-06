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

        // reading
        var items = _employeesRepository.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        // cars
        var cars = GenerateSampleCars();
        foreach (var item in cars)
        {
            _carsRepository.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine("GetUniqueCarColors");
        foreach (var item in _carsProvider.GetUniqueCarColor())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("GetMinimumPriceOfAllCars");
        Console.WriteLine(_carsProvider.GetMinimumPriceAllCars());


        Console.WriteLine();
        Console.WriteLine("GetSpecificColumnsMethod");
        foreach (var item in _carsProvider.GetSpecificColumns())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("AnonymousClassInString");
        Console.WriteLine(_carsProvider.AnonymousClass());

        Console.WriteLine();
        Console.WriteLine("OrderByName");
        foreach (var item in _carsProvider.OrderByName())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("OrderByNameDescending");
        foreach (var item in _carsProvider.OrderByNameDescending())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("OrderByColorAndName");
        foreach (var item in _carsProvider.OrderByColorAndName())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("OrderByColorAndNameDesc");
        foreach (var item in _carsProvider.OrderByColorAndNameDesc())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("WhereStartsWith A");
        foreach (var item in _carsProvider.WhereStartsWith("A"))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("WhereStartsWithAndCostIsGreaterThan A / 1000");
        foreach (var item in _carsProvider.WhereStartsWithAndCostIsGreaterThan("A", 1000))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("WhereColorIsRed");
        foreach (var item in _carsProvider.WhereColorIs("Red"))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("FirstOrDefaultbyColor");
        Console.WriteLine(_carsProvider.FirstOrDefaultByColor("Red"));

        Console.WriteLine();
        Console.WriteLine("FirstOrDefaultbyColor");
        Console.WriteLine(_carsProvider.FirstOrDefaultByColor("Red"));

        Console.WriteLine();
        Console.WriteLine("LastByColor");
        Console.WriteLine(_carsProvider.LastByColor("Red"));


        Console.WriteLine();
        Console.WriteLine("SingleById 10");
        Console.WriteLine(_carsProvider.SingleById(10));

        Console.WriteLine();
        Console.WriteLine("SingleOrDefaultById");
        Console.WriteLine(_carsProvider.SingleOrDefaultById(10));

        Console.WriteLine();
        Console.WriteLine("TakeCars");
        foreach (var car in _carsProvider.TakeCars(10))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("TakeCarsRange");
        foreach (var car in _carsProvider.TakeCars(2..3))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("TakeCarsWhileNameStartsWith S");
        foreach (var car in _carsProvider.TakeCarsWhileNameStartsWith("s"))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine();
        Console.WriteLine("SkipCars");
        foreach (var item in _carsProvider.SkipCars(10))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("SkipCarsWhileNameStartsWith C");
        foreach (var item in _carsProvider.SkipCarsWhileNameStartsWith("c"))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("DistictAllColors");
        foreach (var item in _carsProvider.DistinctAllColors())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("DistictByColors");
        foreach (var item in _carsProvider.DistinctByColors())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("ChunkCars");
        foreach (var item in _carsProvider.ChunkCars(3))
        {
            Console.WriteLine($"Chunk:");
            foreach (var i in item)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("####");
        }

    }

    public static List<Car> GenerateSampleCars()
    {
        return new List<Car>
        {
            new Car { Id = 1, Name = "Car 1", Color = "Black", StandardCost = 1059.31M, ListPrice = 1431.50M, Type = "58" },
            new Car { Id = 2, Name = "Car 2", Color = "Red", StandardCost = 890.25M, ListPrice = 1299.99M, Type = "52" },
            new Car { Id = 3, Name = "Car 3", Color = "Blue", StandardCost = 1120.00M, ListPrice = 1499.00M, Type = "61" },
            new Car { Id = 4, Name = "Car 4", Color = "White", StandardCost = 765.50M, ListPrice = 1099.95M, Type = "47" },
            new Car { Id = 5, Name = "Car 5", Color = "Silver", StandardCost = 980.30M, ListPrice = 1320.00M, Type = "58" },
            new Car { Id = 6, Name = "Car 6", Color = "Green", StandardCost = 1025.75M, ListPrice = 1400.40M, Type = "59" },
            new Car { Id = 7, Name = "Car 7", Color = "Gray", StandardCost = 1150.00M, ListPrice = 1600.00M, Type = "60" },
            new Car { Id = 8, Name = "Car 8", Color = "Orange", StandardCost = 720.15M, ListPrice = 995.50M, Type = "48" },
            new Car { Id = 9, Name = "Car 9", Color = "Yellow", StandardCost = 800.00M, ListPrice = 1090.00M, Type = "51" },
            new Car { Id = 10, Name = "Car 10", Color = "Black", StandardCost = 1320.99M, ListPrice = 1720.45M, Type = "63" },
            new Car { Id = 11, Name = "Car 11", Color = "Blue", StandardCost = 880.10M, ListPrice = 1180.00M, Type = "46" },
            new Car { Id = 12, Name = "Car 12", Color = "Red", StandardCost = 940.00M, ListPrice = 1250.00M, Type = "49" },
            new Car { Id = 13, Name = "Car 13", Color = "Green", StandardCost = 1100.25M, ListPrice = 1500.50M, Type = "53" },
            new Car { Id = 14, Name = "Car 14", Color = "White", StandardCost = 975.00M, ListPrice = 1300.00M, Type = "58" },
            new Car { Id = 15, Name = "Car 15", Color = "Gray", StandardCost = 1075.40M, ListPrice = 1450.75M, Type = "62" }
        };
    }
}