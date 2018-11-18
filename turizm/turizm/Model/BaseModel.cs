using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace turizm.Model
{
    public class BaseModel
    {
      


        public DateTime CreateOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public DateTime DeleteOn { get; set; }
       

        public bool IsDeleted { get; set; }
        public bool IsUpdated { get; set; }
      
        [ForeignKey("CreatedBy")]
        public ulong CreatedById { get; set; }
        public User CreatedBy { get; set; }
        [ForeignKey("UpdateBy")]
        public ulong UpdatedById { get; set; }
        public User UpdateBy { get; set; }
        [ForeignKey("DeletedBy")]
        public ulong DeletedById { get; set; }
        public User DeletedBy { get; set; }







    }
}
