using System.Collections.Generic;

namespace Module4HW3.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
