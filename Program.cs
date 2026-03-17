using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Dictionary<string, double> dict = new Dictionary<string, double>()
        {
            {"item1", 45.50},
            {"item2", 35},
            {"item3", 41.30},
            {"item4", 55},
            {"item5", 24}
        };

        var result = dict
            .OrderByDescending(x => x.Value)
            .Take(3);

        foreach (var item in result)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

        string json = JsonSerializer.Serialize(result);

        File.WriteAllText("result.json", json);

        Console.WriteLine("JSON файл створено");
    }
}