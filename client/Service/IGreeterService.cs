using Client.Model;
using Refit;

namespace Client.Services;

public interface IGreeterService
{
    [Get("/v1/greeter/{name}")]
    Task<HelloReply> SayHelloAPI(string name);
}
