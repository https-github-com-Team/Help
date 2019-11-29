using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpApp.Core.Models
{
    public class Photo
    {
        public Photo()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Məzmun boş ola bilməz")]
        public string Path { get; set; }
        [NotMapped]
         List<IFormFile> Images { get; set; }
        public int ProductId { get; set; }

        public DateTime AddedDate { get; set; }
    }
}