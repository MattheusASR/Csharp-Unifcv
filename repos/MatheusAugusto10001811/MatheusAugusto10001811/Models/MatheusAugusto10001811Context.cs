using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MatheusAugusto10001811.Models
{
    public class MatheusAugusto10001811Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MatheusAugusto10001811Context() : base("name=MatheusAugusto10001811Context")
        {
        }

        public System.Data.Entity.DbSet<MatheusAugusto10001811.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<MatheusAugusto10001811.Models.Produto> Produtoes { get; set; }
    }
}
