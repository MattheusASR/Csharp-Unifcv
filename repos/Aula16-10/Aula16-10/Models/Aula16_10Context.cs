using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula16_10.Models
{
    public class Aula16_10Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Aula16_10Context() : base("name=Aula16_10Context")
        {
        }

        public System.Data.Entity.DbSet<Aula16_10.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Aula16_10.Models.Cidade> Cidades { get; set; }
    }
}
