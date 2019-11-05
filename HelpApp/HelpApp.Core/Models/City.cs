using System;

namespace HelpApp.Core.Models
{
    public class City
    {
        public City()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public DateTime AddedDate { get; set; }
    }
}