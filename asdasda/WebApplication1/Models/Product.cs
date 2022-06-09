using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
        //I Dont make Price required because admin can add first time product 0 
        public double Price { get; set; }
        [Required]
        public double CostPrice { get; set; }
        [Required]
        public double? DiscountPrice { get; set; }
        public int StockCount { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public double Rating { get; set; }
        public Category Category { get; set; }
        public List<ProductImage> ProdutcImages { get; set; }
        [NotMapped]
        public List<IFormFile> Photos { get; set; }
        [NotMapped]
        public IFormFile PhotoFront { get; set; }
        [NotMapped]
        public IFormFile PhotoBack { get; set; }
        [NotMapped]
        public List<int> PhotoIds { get; set; }
    }
}
