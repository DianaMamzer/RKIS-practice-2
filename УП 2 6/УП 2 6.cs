using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    public class DataOfWeather
    {
        public DataOfTemperature Main { get; set; }
    }

    public class DataOfTemperature
    {
        public double temp { get; set; }
    }
        
    static async Task Main(string[] args)
    {
        string urlPageInfo = "https://api.openweathermap.org/data/2.5/weather?lat=56.4977&lon=84.9744&appid=f8d845c3f2c6a227da9a1a1c078ed382";
        using var clientHTTP = new HttpClient();
        var dataAcceptanceClient = await clientHTTP.GetAsync(urlPageInfo); //хранение клиента в переменной (переменная принимает данные)
        string dataDecryptionClient = await dataAcceptanceClient.Content.ReadAsStringAsync(); //расшифровка принятой информации
        DataOfWeather StorageOfRecoverData = JsonConvert.DeserializeObject<DataOfWeather>(dataDecryptionClient); //хранение востановленных данных
        Console.WriteLine($"Погода в Томске: {1.8 * (StorageOfRecoverData.Main.temp - 273)} градусов цельсия"); //перевод в цельсии из кельвинов

    }
}