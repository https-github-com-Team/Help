using System;
using System.Collections.Generic;

namespace HelpApp.Core.Models
{
    public class Country
    {
        public Country()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
        public DateTime AddedDate { get; set; }
    }
}