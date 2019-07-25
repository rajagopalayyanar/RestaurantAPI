using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
namespace RestaurantsAPI.Models
{
    
    public class RestaurantDatabaseSettings//:IRestaurantDatabaseSettings
    {
        
       // public string RestaurantCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    //public interface IRestaurantDatabaseSettings
    //{
    //    string RestaurantCollectionName { get; set; }
    //    string ConnectionString { get; set; }
    //    string DatabaseName { get; set; }
    //}
}

