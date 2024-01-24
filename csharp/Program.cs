using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Calling the Flask API from C#...");

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:5000/");
            
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Response: {result}");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
    }
}
