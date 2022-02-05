using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace DardaniaRealEstate.Models
{
    public class Residence
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public bool Warehouse { get; set; }
        public int GardenSpace { get; set; }
        public int ResidenceSpace { get; set; }
        public string Address { get; set; }
        public bool Garage { get; set; }
        public int Floors { get; set; }
        public int CityDistance { get; set; }
        public int RoomNumber { get; set; }
        public int SleepingRoom { get; set; }
        public int Bathrooms { get; set; }
        public string BuildingType { get; set; }
        public int CommunesID { get;set; }
        public int AgentsID { get; set; }
        public int ConstructionYear { get; set; }
        public string Description { get; set; }
        public string Options { get; set; }//Sale Rent
        public float Price  { get; set; }
        public string GoogleMapsLink { get; set; }
        public virtual Communes Communes { get; set; }
        public virtual Agents Agents { get; set; }
        

        
    }
}
