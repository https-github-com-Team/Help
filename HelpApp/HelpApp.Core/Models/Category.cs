using System;
using System.Collections.Generic;

namespace HelpApp.Core.Models
{
    public class Category
    {
        public Category()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime AddedDate { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}