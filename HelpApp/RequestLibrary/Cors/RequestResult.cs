using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpApp.Core.Models;
using RestSharp;

namespace RequestLibrary.Cors
{
    public class RequestResult<T>
    {
        public bool IsSucced { get; set; }

        private StandartAnswer<T> _answer;
        public StandartAnswer<T> Answer { get
            {
                return _answer;
            }
            set {
                _answer = value;
            }
        }

        public string ErrorMessage { get; set; }
    }
}
