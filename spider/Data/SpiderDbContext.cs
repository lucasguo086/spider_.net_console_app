using System.Text;
using Microsoft.EntityFrameworkCore;
using spider.Model;
using spider.Utils;

namespace spider.Data;

public class SpiderDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Server=tcp:lucasguo811.database.windows.net,1433;Initial Catalog=eshop;Persist Security Info=False;User ID={Encoding.UTF8.GetString(Convert.FromBase64String(Key.User))};Password={Encoding.UTF8.GetString(Convert.FromBase64String(Key.Psw))};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}