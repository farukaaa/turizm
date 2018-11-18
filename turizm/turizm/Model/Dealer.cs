using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace turizm.Model
{
    public class Dealer:BaseModel
    {

        public ulong ID { get; set; } 
        public Guid Guid { get; set; }

        public string Name { get; set; }

        [ForeignKey("Address")]
        public uint AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Contact")]
        public ulong ContactId { get; set; }
        public Contact Contact { get; set; }

        [ForeignKey("City")]
        public byte CityCode { get; set; }
        public City City { get; set; }

        [ForeignKey("District")]
        public ulong DistrictCode { get; set; }
        public District District { get; set; }






    }
}
