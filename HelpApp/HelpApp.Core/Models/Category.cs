using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelpApp.Core.Models
{
    public class Category
    {
        public Category()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string Name { get; set; }

        public DateTime AddedDate { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}