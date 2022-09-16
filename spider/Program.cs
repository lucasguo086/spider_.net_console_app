using System.Text;
using spider.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using spider.Data;
using spider.Dto;
using spider.Model;
using spider.Service;
using spider.Utils;

namespace spider;

static class Program
{
    private static readonly string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:104.0) Gecko/20100101 Firefox/104.0";
    private static readonly string AccessUrl = "https://www.jayagrocer.com/collections/alcohol/products.json";
    static async Task Main(string[] args)
    {
        DbService.DeleteAllProduct();
        int numberOfElements = 1;
        int page = 1;
        while (numberOfElements != 0)
        {
            HttpClientDriver driver = new HttpClientDriver("https://www.jayagrocer.com/collections/alcohol/products.json?page="+page);
            driver.AddHeader("User-Agent",UserAgent);
            String result = await driver.GetPageSource();
            numberOfElements = JsonUtils.GetArrayLength(result, "products");
            Console.WriteLine("This page have "+numberOfElements+" products");
            JsonFormatter.StoreJsonData(result);
            page++;
        }

    }

    

}

