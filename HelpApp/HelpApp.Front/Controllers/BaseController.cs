using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RequestLibrary.Cors;
using RequestLibrary.Cors.Services;

namespace HelpApp.Front.Controllers
{
    public class BaseController : Controller
    {
        public Service _service;
        protected readonly HttpClient _HttpClient = new HttpClient();
#if DEBUG
        protected string _Url = "https://localhost:44335/";
#else
        protected string _Url = "production link";
#endif 
        public BaseController()
        {
            var request = new RequestSender();
            _service = new Service(request);
        }
    }
}