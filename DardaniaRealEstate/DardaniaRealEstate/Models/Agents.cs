using System.Collections.Generic;

namespace DardaniaRealEstate.Models
{
    public class Agents
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Photo { get;set; }
       
        public virtual ICollection <Residence> Residence { get; set; } 
        public virtual ICollection <Properties> Properties { get;set; }

    }
}
