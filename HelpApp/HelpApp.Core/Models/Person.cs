using System;

namespace HelpApp.Core.Models
{
    public class Person
    {
        public Person()
        {
            AddedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AddedDate { get; set; }
    }
}