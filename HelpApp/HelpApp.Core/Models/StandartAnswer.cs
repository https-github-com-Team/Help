using HelpApp.Core.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Models
{
    public class StandartAnswer<T>
    {
        public ResultCodes Code { get; set; }

        public string CodeName { get { return Code.ToString(); } }
        public T Data { get; set; }

        public string ErrorMessage { get; set; }
        public string Description { get; set; }
    }
}
