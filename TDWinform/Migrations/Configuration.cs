namespace TDWinform.Migrations
{

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TDWinform.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TDWinform.ModelTD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TDWinform.ModelTD";
        }

        protected override void Seed(TDWinform.ModelTD context)
        {

            context.Groups.AddOrUpdate(
                 p => p.GroupId,
                 new Group { GroupId = 1, Name = "Group 1" },
                 new Group { GroupId = 2, Name = "Group 2" },
                 new Group { GroupId = 3, Name = "Group 3" }
               );

            context.Students.AddOrUpdate(
             p => p.GroupId,
             new Student { StudentId = 1, Age = 22, GroupId = 1, LastName = "Ali" },
             new Student { StudentId = 2, Age = 22, GroupId = 1, LastName = "Karim" },
             new Student { StudentId = 3, Age = 22, GroupId = 1, LastName = "Mouad" },
             new Student { StudentId = 4, Age = 22, GroupId = 2, LastName = "Kamal" },
             new Student { StudentId = 5, Age = 23, GroupId = 2, LastName = "Fatima" },
             new Student { StudentId = 6, Age = 23, GroupId = 2, LastName = "Mouna" },
             new Student { StudentId = 7, Age = 23, GroupId = 2, LastName = "Nabil" },
             new Student { StudentId = 8, Age = 23, GroupId = 2, LastName = "Ikram" },
             new Student { StudentId = 9, Age = 23, GroupId = 3, LastName = "Ali" },
             new Student { StudentId = 10, Age = 23, GroupId = 3, LastName = "Mouad" }
           );

        }
    }
}
