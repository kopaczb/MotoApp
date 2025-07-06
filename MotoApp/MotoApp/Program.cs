﻿// V - LINQ to XML 

using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.DataProviders;
using MotoApp.Entities;
using MotoApp.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();
services.AddSingleton<IRepository<Car>, ListRepository<Car>>();
services.AddSingleton<ICarsProvider, CarsProvider>();

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>();
app.Run();


// *******************
// Tu trzeba zacząć
// Wprowadzenie
// *******************