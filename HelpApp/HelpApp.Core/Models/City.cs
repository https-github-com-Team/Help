using System;
using System.ComponentModel.DataAnnotations;

namespace HelpApp.Core.Models
{
    public class City
    {
        public City()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        [StringLength(150)]
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public DateTime AddedDate { get; set; }
    }
}