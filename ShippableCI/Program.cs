using System;
using Newtonsoft.Json.Linq;

namespace ShippableCI
{
    class Program
    {
        static void Main(string[] args)
        {
            JArray array = new JArray();
            array.Add("Manual text");
            array.Add(new DateTime(2000, 5, 23));

            JObject o = new JObject();
            o["MyArray"] = array;

            Console.WriteLine("Hello World!");
            Console.WriteLine("JSON string: " + o.ToString());
        }
    }
}
