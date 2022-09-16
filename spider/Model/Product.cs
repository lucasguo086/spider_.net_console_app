using System.ComponentModel.DataAnnotations;

namespace spider.Model;

public class Product
{
    [Key]
    public string Sku { set; get; }
    public string Name { set; get; }
    public float Price { set; get; }
    public string? ImageLink { set; get; }
    public string? Abv { set; get; }
    public string? Category { set; get; }
    public string? BottleSize { set; get; }
    public DateTime CollectionDate { set; get; }
}