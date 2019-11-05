using System;

namespace HelpApp.Core.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime AddedDate { get; set; }
    }
}