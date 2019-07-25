using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantsAPI.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
        }
        [BsonId(IdGenerator =typeof(StringObjectIdGenerator))]
        public string RestaurentId { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public long Contact { get; set; }
        public double Ratings { get; set; }
    }
}
