namespace DardaniaRealEstate.Models
{
    public class Office
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int CommunesID { get; set; }
        public int Squaremetres { get; set; }
        public bool Warehouse { get; set; }
        public bool Bathroom { get; set; }
        public string Options { get; set; }
        public string Photo { get; set; }
        public string GoogleMapsLink { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }



        public virtual Communes Communes { get; set; }


    }
}
