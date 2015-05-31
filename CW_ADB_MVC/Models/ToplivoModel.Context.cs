
namespace CW_ADB_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class toplivoEntities : DbContext
    {
        public toplivoEntities()
            : base("name=toplivoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fuels> Fuels { get; set; }
        public virtual DbSet<Operations> Operations { get; set; }
        public virtual DbSet<Tanks> Tanks { get; set; }
        public virtual DbSet<View_AllOperations> View_AllOperations { get; set; }
    }
}
