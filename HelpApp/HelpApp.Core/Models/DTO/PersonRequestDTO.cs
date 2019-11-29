using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Models.DTO
{
    public class PersonRequestDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }


        public override string ToString()
        {
            return $"Name:{Name},Surname:{Surname},PhoneNumber:{PhoneNumber}";
        }
    }
}
