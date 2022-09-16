using System.ComponentModel.DataAnnotations;
namespace spider.Model;
// Once change the model for product, we should update Migrations and update the database
// dotnet ef migrations add IniticalCreate
// dotnet ef database update
public class Product
{
    [Key] 
    public int Id { set; get; }
    public string Sku { set; get; }
    public string Name { set; get; }
    public float Price { set; get; }
    public string? ImageLink { set; get; }
    public string? Abv { set; get; }
    public string? Category { set; get; }
    public string? BottleSize { set; get; }
    public DateTime CollectionDate { set; get; }
}