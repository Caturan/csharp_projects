using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçiniz ###");
Console.WriteLine("1- Şehir Listesini Bilgisi Getir");
Console.WriteLine("2- Yeni Şehir Ekleme");
Console.WriteLine("3- Şehir Silme İşlemi");
Console.WriteLine("4- Şehir Güncelleme İşlemi");
Console.WriteLine("5- ID'ye Göre Şehir Getirme İşlemi");

string number; 

Console.WriteLine("Seçiminiz: ");
number = Console.ReadLine();

if (number=="1")
{
    string url = "https://localhost:7008/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);  
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);  
        foreach(var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temp"].ToString(); 
            string country = item["country"].ToString();    
            Console.WriteLine(cityName + " - " + country + " --> " + temp);
        }

    }
}   
if(number == "2")
{
    Console.WriteLine("Yeni Şehir Ekleme");
}
if(number == "3")
{
    Console.WriteLine("Şehir Silme İşlemi");
}   