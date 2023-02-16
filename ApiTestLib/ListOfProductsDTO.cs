using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestLib
{
    public partial class ListOfProductsDTO
    {
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public List<Data> Data { get; set; }
    }

    public partial class Data
    {
        public int ProductId { get; set; }
        
        public string ProductName { get; set; } = null!;
        
        public int? SupplierId { get; set; }
        
        public int? CategoryId { get; set; }
        
        public string? QuantityPerUnit { get; set; }
        
        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }
    }
}
