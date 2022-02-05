using System.Collections.Generic;

namespace DardaniaRealEstate.Models
{
    public class Communes
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection <Residence> Residence { get; set; }
        public virtual ICollection <Properties> Properties { get; set; }
        public virtual ICollection <Office> Office { get; set; }
    }
}
