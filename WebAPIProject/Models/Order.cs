using Newtonsoft.Json;

namespace WebAPIProject.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        [JsonIgnore]
        public virtual Customer Customer { get; set; }
        public virtual List<Product> Products { get; set; } 
    }
}
