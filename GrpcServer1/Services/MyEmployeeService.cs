using Grpc.Core;
using GrpcServer.Proto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer1.Services
{
  public class MyEmployeeService:GetEmployee.GetEmployeeBase
  {
    private readonly ILogger<MyEmployeeService> _logger;
    public MyEmployeeService(ILogger<MyEmployeeService> logger)
    {
      _logger = logger;
    }
    public override Task<GetResponse> GetByNo(GetByNoRequest request, ServerCallContext context)
    {
      return Task.FromResult(new GetResponse()
      {
        Employee = new Employee() {Id=1,No=1,Name="1213" }
      });
    }



  }
}
