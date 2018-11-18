using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace turizm.Model
{
    public class UserRoles
    {


        public uint ID { get; set; } 
        public Guid Guid { get; set; }

        public string Name { get; set; }


        [ForeignKey("UserAuth")]
        public byte UserAuthId { get; set; }

        public UserAuth UserAuth { get; set; }





    }
}
