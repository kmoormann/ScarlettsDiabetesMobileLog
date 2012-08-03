using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScarlettsLog.Mobile.Models
{
    public class ScarlettsLogMobileContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ScarlettsLog.Mobile.Models.ScarlettsLogMobileContext>());

        public ScarlettsLogMobileContext() : base("ScarlettsLogDatabase") { }

        public DbSet<ScarlettsLog.Mobile.Models.LogModel> LogModels { get; set; }

        public DbSet<ScarlettsLog.Mobile.Models.LogEntry> LogEntries { get; set; }
    }
}