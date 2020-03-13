using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class Service : MessageService.MessageServiceBase
    {
        public override Task<SampleResponse> Ping(SampleRequest request, ServerCallContext context)
        {
            var response = new SampleResponse
            {
                Conteudo = $"{request.Conteudo}:{string.Join("", request.Conteudo.ToArray().Reverse())}",
                Id = 7
            };
            return Task.FromResult(response);
        }
    }
}
