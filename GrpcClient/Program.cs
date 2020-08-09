using Grpc.Net.Client;
using GrpcServer.Proto;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
  class Program
  {
    static async Task Main(string[] args)
    {
      AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
      using var channel = GrpcChannel.ForAddress("http://localhost:5001");

      var client = new GetEmployee.GetEmployeeClient(channel);

      var response = await client.GetByNoAsync(new GetByNoRequest
      {
        No = 1
      });





      Console.WriteLine("Hello World!");
    }
  }
}
