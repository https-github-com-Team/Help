using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;


namespace HelpApp.Core.Models.DTO
{
    public  class ProductRequestDTO
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public int PersonId { get; set; }
       
        public List<IFormFile> Files { get; set; }

        public DateTime? PublishDate { get; set; }
        public DateTime? EndedDate { get; set; }

        public override string ToString()
        {
            return $"Name:{Name},Description:{Description},CategoryId:{CategoryId},CityId:{CityId},PersonId:{PersonId},PublishDate:{PublishDate},EndedDate:{EndedDate}";
        }
    }
}
