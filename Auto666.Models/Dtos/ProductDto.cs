using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto666.Models.Dtos
{
    public class ProductDto
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
        public string CategoryName { get; set; }
    }
}
