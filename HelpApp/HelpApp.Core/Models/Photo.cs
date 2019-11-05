using System;

namespace HelpApp.Core.Models
{
    public class Photo
    {
        public Photo()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }

        public string Path { get; set; }

        public DateTime AddedDate { get; set; }
    }
}