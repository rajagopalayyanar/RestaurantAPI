using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RestaurantsAPI.Models;

namespace RestaurantsAPI.Infrastructure
{
    public class RestaurantDBContext
    {
        //private readonly IMongoCollection<Restaurant> _restaurant;
        //private MongoSettings mongoSettings;
        //private readonly IMongoDatabase database;
        //public RestaurantDBContext(IRestaurantDatabaseSettings settings)
        //{
        //    var client = new MongoClient(settings.ConnectionString);
        //     database = client.GetDatabase(settings.DatabaseName);

        //    //_restaurant = database.GetCollection<Restaurant>(settings.RestaurantCollectionName);
        //}

        //public IMongoCollection<Restaurant> Restaurant
        //{
        //    get
        //    {
        //        return this.database.GetCollection<Restaurant>("Restaurant");
        //    }
        //}


        private readonly IMongoDatabase database;
        private RestaurantDatabaseSettings _restaurantDatabaseSettings;
        public RestaurantDBContext(IOptions<RestaurantDatabaseSettings> options)
        {
            this._restaurantDatabaseSettings = options.Value;
            MongoClientSettings clientSettings = MongoClientSettings.FromConnectionString(_restaurantDatabaseSettings.ConnectionString);
            MongoClient client = new MongoClient(clientSettings);
            if (client != null)
            {
                this.database = client.GetDatabase(_restaurantDatabaseSettings.DatabaseName.Trim());
            }
            //_restaurant = database.GetCollection<Restaurant>(settings.RestaurantCollectionName);
        }

        public IMongoCollection<Restaurant> Restaurant
        {
            get
            {
                return this.database.GetCollection<Restaurant>("Restaurant");
            }
        }
    }
}
