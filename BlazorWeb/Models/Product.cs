using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }=default!;
    [Range(1,1000)]
    public double Price { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<Product_Prop> ProductProperties { get; set; }=new List<Product_Prop>();
    public Category Category { get; set; }

    public DateOnly AvailableAfter { get; set; }
}

public enum Category
{
    Electronics,
    Clothing,
    HomeAppliances,
    Books,
    Toys
}
