using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Core.Models.DTO
{
    public class CategoryRequestDTO
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"name: {Name}";
        }
    }
}
