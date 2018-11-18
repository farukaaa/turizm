using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace turizm.Model
{
    public class Contact:BaseModel
    {

        public ulong ID { get; set; } 
        public Guid Guid { get; set; }

        public string Email { get; set; }
        public string Telephone { get; set; }
        public string MobilPhone { get; set; }

        [ForeignKey("User")]
        public ulong UserId { get; set; }
        public User User { get; set; }








    }
}
