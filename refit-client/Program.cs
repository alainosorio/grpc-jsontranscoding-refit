using Client.Services;
using Refit;

var api = RestService.For<IGreeterService>(new HttpClient()
{
    BaseAddress = new Uri("https://localhost:7013"),
    DefaultRequestVersion = new Version(2, 2),
});

var data = await api.SayHelloAPI("Alain!");

Console.WriteLine(data.Message.ToString());
Console.ReadLine();
