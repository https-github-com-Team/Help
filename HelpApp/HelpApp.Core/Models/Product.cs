using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Models
{
    public class Product
    {
        public Product()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
