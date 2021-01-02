using ConsoleDemo;
using System;
using System.Net.Http;
using System.Threading.Tasks;

// Use HttpClient Factory - DI - this below one is not the right way to do it
swaggerClient client = new("https://localhost:44375/", new HttpClient());
var records = await client.WeatherForecastAsync();
foreach (var r in records)
{
    Console.WriteLine($"{r.Date}: {r.Summary}");
}
Console.Read();
