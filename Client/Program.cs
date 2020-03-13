using Grpc.Net.Client;
using GrpcServer.Services;
using Newtonsoft.Json;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new MessageService.MessageServiceClient(channel);

            Console.WriteLine("Digite a mensagem");
            var mensagem = Console.ReadLine();

            var request = new SampleRequest
            {
                Conteudo = mensagem,
                Id = 1
            };

            var response = client.Ping(request);

            Console.WriteLine(JsonConvert.SerializeObject(response));
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
