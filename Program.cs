using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
  static async Task Main(string[] args)
  {
    string apiUrl = "http://localhost:5212/gamedata/";

    await RunSmokeTest(apiUrl);

  }
  static async Task RunSmokeTest(string apiUrl)
  {

    using HttpClient client = new();
    try
    {
      HttpResponseMessage response = await client.GetAsync(apiUrl);

      if (response.IsSuccessStatusCode)
      {
        Console.WriteLine($"Smoke Test Passed: {response.StatusCode}");

        Console.WriteLine(responseData);
      }
      else
      {
        Console.WriteLine($"Smoke Test Failed: {response.StatusCode}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Exception during Smoke Test: {ex.Message}");
    }
  }
}
