//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPortfolioProject.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMyPortfolioEntities : DbContext
    {
        public DbMyPortfolioEntities()
            : base("name=DbMyPortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_About> Tbl_About { get; set; }
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_Experience> Tbl_Experience { get; set; }
        public virtual DbSet<Tbl_Message> Tbl_Message { get; set; }
        public virtual DbSet<Tbl_Services> Tbl_Services { get; set; }
        public virtual DbSet<Tbl_ServicesFeature> Tbl_ServicesFeature { get; set; }
        public virtual DbSet<Tbl_Testimonial> Tbl_Testimonial { get; set; }
        public virtual DbSet<Tbl_Project> Tbl_Project { get; set; }
    }
}
