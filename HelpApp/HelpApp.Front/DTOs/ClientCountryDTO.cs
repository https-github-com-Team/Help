using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpApp.Front.DTOs
{
    public class ClientCountryDTO
    {
        public string Name { get; set; }
        public ICollection<ClientCityDTO> Cities { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
