using System;
using System.ComponentModel.DataAnnotations;

namespace HelpApp.Core.Models
{
    public class Person
    {
        public Person()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string Name { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string Surname { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string PhoneNumber { get; set; }
        public DateTime AddedDate { get; set; }
    }
}