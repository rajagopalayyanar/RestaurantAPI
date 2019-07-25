using RestaurantsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Services
{
    public interface IRestaurantService
    {
        Task<List<Restaurant>> Get();
        Task<Restaurant> Get(string name);
        Task<Restaurant> GetFilterByRating(double ratings);
        Restaurant Create(Restaurant restaurant);
    }
}
