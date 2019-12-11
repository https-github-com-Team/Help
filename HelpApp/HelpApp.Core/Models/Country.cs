using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelpApp.Core.Models
{
    public class Country
    {
        public Country()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        [StringLength(150)]
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public DateTime AddedDate { get; set; }
    }
}