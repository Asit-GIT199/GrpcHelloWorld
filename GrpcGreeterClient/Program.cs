using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "Swn Client" }
                );

            Console.WriteLine("Greetings: " + reply.Message);
            Console.ReadKey();
        }
    }
}
