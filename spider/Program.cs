using System.Text;
using spider.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using spider.Data;
using spider.Dto;
using spider.Model;
using spider.Utils;

namespace spider;

static class Program
{
    private static readonly string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:104.0) Gecko/20100101 Firefox/104.0";
    private static readonly string AccessUrl = "https://www.jayagrocer.com/collections/alcohol/products.json";
    static async Task Main(string[] args)
    {
        //翻页和loopCommand写法
        //link manager
        HttpClientDriver driver = new HttpClientDriver(AccessUrl);
        driver.AddHeader("User-Agent",UserAgent);
        String result = await driver.GetPageSource();
        
        JObject json = JObject.Parse(result);
        JArray productList = JArray.Parse(json["products"].ToString());
        for (int i = 0; i <productList.Count; i++)
        {
            string name = json["products"][i]["title"].ToString();
            string imgLink = json["products"][i]["images"][0]["src"].ToString();
            JArray variantList = JArray.Parse(json["products"][i]["variants"].ToString());
            for (int j = 0; j <variantList.Count; j++)
            {
                string sku = json["products"][i]["variants"][j]["id"].ToString();
                string bottleSize = json["products"][i]["variants"][j]["title"].ToString();
                string price = json["products"][i]["variants"][j]["price"].ToString();
                ProductInput productInput = new ProductInput()
                {
                    Sku = sku,
                    Name = name,
                    Price = (float)Convert.ToDecimal(price),
                    ImageLink = imgLink,
                    BottleSize = bottleSize
                };
                DbService.AddRecords(productInput);
            }
            
        }
        


    }

    

}

