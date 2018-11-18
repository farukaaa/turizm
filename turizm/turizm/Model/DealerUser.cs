using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace turizm.Model
{
    public class DealerUser:BaseModel
    {

        public ulong ID { get; set; } 
      


        [ForeignKey("Dealer")]
        public uint DealerId { get; set; }
        public Dealer Dealer { get; set; }

        [ForeignKey("UserId")]
        public ulong UserId { get; set; }
        public User User { get; set; }







    }
}
