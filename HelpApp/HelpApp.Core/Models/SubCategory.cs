using System;
using System.ComponentModel.DataAnnotations;

namespace HelpApp.Core.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime AddedDate { get; set; }
    }
}