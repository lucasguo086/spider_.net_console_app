using Newtonsoft.Json.Linq;
using spider.Data;
using spider.Dto;
using spider.Model;

namespace spider.Service;

public static class JsonFormatter
{
    public static void StoreJsonData(string pageSource)
    {
        DbService.DeleteAllProduct();
        JObject json = JObject.Parse(pageSource);
        //according to JSON format to organize the code
        JArray productList = JArray.Parse(json["products"].ToString());
        for (int i = 0; i <productList.Count; i++)
        {
            string name = json["products"][i]["title"].ToString();
            string imgLink ="";
            try
            {
                imgLink = json["products"][i]["images"][0]["src"].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("No images for this products");
            }
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
                Product product = DbService.AddRecords(productInput);
                Console.WriteLine(product.Name);
            }
        }
    }
   
}
