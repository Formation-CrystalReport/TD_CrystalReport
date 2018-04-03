namespace TDWinform
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TDWinform.Entities;

    public class ModelTD : DbContext
    {
         public ModelTD()
            : base("name=ModelTD")
        {
        }


        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }
 
}