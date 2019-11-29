using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Models.DTO
{
    public class SubCategoryRequestDTO
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return $"Name: {Name},CategoryId:{CategoryId}";
        }
    }
}
