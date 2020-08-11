using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GrpcServer1
{
  [Route("[controller]")]
  //[ApiController]
  public class HomeController : ControllerBase
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IConfigurationRoot _configRoot;
    public HomeController(ILogger<HomeController> logger, IConfigurationRoot configRoot)
    {
      _logger = logger;
      _configRoot = configRoot;
    }

    public IActionResult GetConfigInfo()
    {
      var PositionTitle = _configRoot["Position:Title"];


      return null;
    }
  }
}
