using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace turizm.Model
{
    public class Address:BaseModel
    {

        public uint ID { get; set; } 
        public Guid Guid { get; set; }

        public string Address { get; set; }

        [ForeignKey("User")]
        public ulong UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("City")]
        public byte CityCode { get; set; }
        public City City { get; set; }

        [ForeignKey("District")]
        public ulong DistrictCode { get; set; }
        public District District { get; set; }






    }
}
