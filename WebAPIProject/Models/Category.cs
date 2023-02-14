﻿namespace WebAPIProject.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
