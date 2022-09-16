namespace spider.Dto;

using System.ComponentModel.DataAnnotations;

public class ProductInput
{
    [Key]
    public string Sku { set; get; }
    public string Name { set; get; }
    public float Price { set; get; }
    public string? ImageLink { set; get; }
    public string? Abv { set; get; }
    public string? Category { set; get; }
    public string? BottleSize { set; get; }
}