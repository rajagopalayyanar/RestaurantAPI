using RestaurantsAPI.Infrastructure;
using RestaurantsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace RestaurantsAPI.Services
{
    public class RestaurantService:IRestaurantService
    {
        private RestaurantDBContext _restaurantDBContext;
        public RestaurantService(RestaurantDBContext restaurantDBContext)
        {
            _restaurantDBContext = restaurantDBContext;
        }

        public async Task<List<Restaurant>> Get() {
            var restaurants=await _restaurantDBContext.Restaurant.FindAsync(restaurant => true);
            return restaurants.ToList();
        }
        public async Task<Restaurant> Get(string name)
        {
          var restaurant= await _restaurantDBContext.Restaurant.FindAsync<Restaurant>(rest => rest.RestaurentId == name);
            return restaurant.FirstOrDefault();
        }

        public async Task<Restaurant> GetFilterByRating(double ratings)
        {
            var restaurant = await _restaurantDBContext.Restaurant.FindAsync<Restaurant>(rest => rest.Ratings == ratings);
            return restaurant.FirstOrDefault();
        }
        public Restaurant Create(Restaurant restaurant)
        {
            //restaurant = new Restaurant
            //{
            //    RestaurantName = "ABC Restaurent",
            //    Location = "Chennai",
            //    Contact = 40,

            //};
            _restaurantDBContext.Restaurant.InsertOne(restaurant);
            return restaurant;
        }
    }
}
