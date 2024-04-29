using System.ComponentModel.DataAnnotations.Schema;

namespace Auto666.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Mark { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int Price { get; set; }
        public int Year { get; set; } 
        public string Transmission { get; set; }
        public int Range { get; set; }
        public string City { get; set; }
        public double Volume { get; set; }
        public int Horses { get; set; }
        public string FuelType { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public ProductCategory ProductCategory { get; set; }

    }
}
