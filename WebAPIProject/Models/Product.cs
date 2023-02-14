using Newtonsoft.Json;

namespace WebAPIProject.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
        public int CategoryID { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}
