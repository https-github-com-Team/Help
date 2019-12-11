using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelpApp.Front.Controllers
{
    public class BaseController : Controller
    {
        protected readonly HttpClient _HttpClient = new HttpClient();
#if DEBUG
        protected string _Url = "https://localhost:44335/";
#else
        protected string _Url = "production link";
#endif 
    }
}