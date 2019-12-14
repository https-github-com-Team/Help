using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestLibrary.Cors.Services
{
    public partial class Service
    {
        private readonly RequestSender _requestSender = null;
        public Service(RequestSender requestSender)
        {
            _requestSender = requestSender;

        }
    }
}
