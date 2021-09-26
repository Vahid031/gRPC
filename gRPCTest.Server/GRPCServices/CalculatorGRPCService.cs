using Grpc.Core;
using gRPCTest.Server.Protos;
using System.Threading.Tasks;

namespace gRPCTest.Server.GRPCServices
{
    public class CalculatorGRPCService : CalculatorService.CalculatorServiceBase
    {
        public override Task<SumResponse> Sum(SumRequest request, ServerCallContext context)
        {
            SumResponse result = new()
            {
                Result = request.FirstNumber + request.SecondNumber
            };

            return Task.FromResult(result);
        }
    }
}
