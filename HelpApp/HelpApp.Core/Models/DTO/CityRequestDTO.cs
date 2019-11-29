using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Models.DTO
{
    public class CityRequestDTO
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public override string ToString()
        {
            return $"name: {Name},countryId:{CountryId}";
        }
    }
}
