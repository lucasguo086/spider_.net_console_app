using Newtonsoft.Json.Linq;

namespace spider.Utils;

public static class JsonUtils
{
    public static int GetArrayLength(string pageSource,string token)
    {
        JObject json = JObject.Parse(pageSource);
        JArray productList = JArray.Parse(json[token].ToString());
        int length = productList.Count;
        return length;
    }
}