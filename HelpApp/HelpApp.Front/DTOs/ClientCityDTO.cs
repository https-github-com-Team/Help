using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpApp.Front.DTOs
{
    public class ClientCityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
