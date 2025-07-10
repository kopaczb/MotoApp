using MotoApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Components.DataProviders.Extensions
{
    public static class CarsHelper
    {
        public static IEnumerable<Car> ByColor(this IEnumerable<Car> query, string color)
        {
            return query.Where(x => x.Color == color);
        }
    }
}