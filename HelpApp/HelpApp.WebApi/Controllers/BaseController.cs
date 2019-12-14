using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpApp.Infrastructure.Db;
using Microsoft.AspNetCore.Mvc;

namespace HelpApp.WebApi.Controllers
{
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        
    }
}