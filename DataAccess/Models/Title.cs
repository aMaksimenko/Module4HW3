using System.Collections.Generic;

namespace HomeWork.DataAccess.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}