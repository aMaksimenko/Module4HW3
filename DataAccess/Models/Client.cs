using System.Collections.Generic;

namespace HomeWork.DataAccess.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string CountryFrom { get; set; }
        public virtual List<Project> Projects { get; set; } = new List<Project>();
    }
}