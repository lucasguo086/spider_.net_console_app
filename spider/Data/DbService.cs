using spider.Dto;
using spider.Model;
namespace spider.Data;
public static class DbService
{
    public static Product AddRecords(ProductInput productInput)
    {
        //create records for the Products table

        Product product = new Product()
        {
            Sku = productInput.Sku,
            Name = productInput.Name,
            Price = productInput.Price,
            ImageLink = productInput.ImageLink,
            Abv = productInput.Abv,
            Category = productInput.Category,
            BottleSize = productInput.BottleSize,
            CollectionDate = DateTime.Now
        };
        using SpiderDbContext dbContext = new SpiderDbContext();
        dbContext.Products.Add(product);
        dbContext.SaveChanges();
        return product;
    }
    
    public static void DeleteProduct(string sku)
    {
        //Delete records for the Products table
        using SpiderDbContext dbContext = new SpiderDbContext();
        Product product = dbContext.Products.FirstOrDefault<Product>(c => c.Sku == sku);
        if (product != null)
        {
            dbContext.Remove(product);
            dbContext.SaveChanges();
        }
        else
            Console.WriteLine("No such record");
    }
}