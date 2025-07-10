﻿// V - LINQ to XML 

using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Components.CsvReader;
using MotoApp.Components.DataProviders;
using MotoApp.Data.Entities;
using MotoApp.Data.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();
services.AddSingleton<IRepository<Car>, ListRepository<Car>>();
services.AddSingleton<ICarsProvider, CarsProvider>();
services.AddSingleton<ICsvReader, CsvReader>();

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>();
app.Run();


// *******************
// Tu trzeba zacząć
// Korzystanie z metody GroupBy
// https://edu.gotoit.pl/index.php/kurs-c-od-podstaw-poziom-sredniozaawansowany/linq-to-xml/korzystanie-z-metody-groupby/
// *******************