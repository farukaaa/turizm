using System;
namespace turizm.Model
{
    public class User:BaseModel
    {

        public ulong ID { get; set; } 
        public Guid Guid { get; set; }

        public string Name { get; set; }
        public string UserFoto { get; set; }






    }
}
