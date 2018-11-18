using System;
using  Microsoft.EntityFrameworkCore;
using turizm.Model;

namespace turizm.DB
{
    public class Context:DbContext
    {
        public DbSet<UserRoles> UserRoles { get; set; }


    }
}
