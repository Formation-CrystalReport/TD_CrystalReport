namespace Entities
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelTD : DbContext
    {
        public ModelTD(): base("name=ModelTD")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student> Groups { get; set; }

    }

   
}