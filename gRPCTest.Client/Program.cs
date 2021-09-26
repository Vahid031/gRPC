using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using gRPCTest.Server.Protos;

namespace gRPCTest.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001/");

            var client = new CalculatorService.CalculatorServiceClient(grpcChannel);

            var request = new SumRequest
            {
                FirstNumber = 9,
                SecondNumber = 5
            };

            SumResponse response = await client.SumAsync(request);


            Console.WriteLine($"result : {response.Result}");
            Console.ReadKey();
        }
    }
}
