using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApp02.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("DataBase")        //ovaj string je naziv baze
        {

        }

        public virtual DbSet<User> Students { get; set; }
    }
}