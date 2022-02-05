namespace DardaniaRealEstate.Models
{
    public class Properties
    {
        public int Id { get; set; }
        public int CommunesID { get; set; } 
        public int AgentsID { get; set; }
        public string Location { get; set; }
        public int Squaremeters { get; set; }
        public string Photo { get; set; }
        public string GoogleMapsLink { get; set; }
        public string Sketch { get; set; }
        public int Price { get; set; }

        public virtual Communes Communes { get; set; }
        public virtual Agents Agents { get; set; }
    }
}
