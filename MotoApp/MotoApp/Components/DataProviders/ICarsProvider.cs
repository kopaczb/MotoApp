using MotoApp.Data.Entities;

namespace MotoApp.Components.DataProviders;

public interface ICarsProvider
{
    // ---------------------
    // Zastosowanie select
    // ---------------------
    List<string> GetUniqueCarColor();
    decimal GetMinimumPriceAllCars();
    List<Car> GetSpecificColumns();
    string AnonymousClass();
    // ---------------------------------------------


    // -------------------------
    // Różne sposoby Ordering’u
    // -------------------------
    List<Car> OrderByName();
    List<Car> OrderByNameDescending();
    List<Car> OrderByColorAndName();
    List<Car> OrderByColorAndNameDesc();
    // ---------------------------------------------


    // ---------------------
    // Filtrowanie z Where 
    // --------------------- 
    List<Car> WhereStartsWith(string prefix);
    List<Car> WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost);
    List<Car> WhereColorIs(string color);
    // ---------------------------------------------


    // -------------------------
    // Metody First i Single
    // ------------------------- 
    Car FirstByColor(string color);
    Car? FirstOrDefaultByColor(string color);
    Car FirstOrDefaultByColorWithDefault(string color);
    Car LastByColor(string color);
    Car SingleById(int id);
    Car? SingleOrDefaultById(int id);
    // ---------------------------------------------


    // -------------------------
    // Metoda Take
    // -------------------------
    List<Car> TakeCars(int howMany);
    List<Car> TakeCars(Range range);
    List<Car> TakeCarsWhileNameStartsWith(string prefix);
    // ---------------------------------------------


    // -------------------------
    // Metoda Skip
    // -------------------------
    List<Car> SkipCars(int howMany);
    List<Car> SkipCarsWhileNameStartsWith(string prefix);
    // ---------------------------------------------


    // -------------------------
    // Metoda Distinct
    // -------------------------
    List<string> DistinctAllColors();
    List<Car> DistinctByColors();
    // ---------------------------------------------


    // -------------------------
    // Metoda Chunk
    // -------------------------
    List<Car[]> ChunkCars(int size);
    // ---------------------------------------------
}