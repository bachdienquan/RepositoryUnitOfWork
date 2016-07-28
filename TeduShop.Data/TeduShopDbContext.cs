using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public class TeduShopDbContext : IdentityDbContext<ApplicationUser, ApplicationRole,
        string, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }



        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }
        public DbSet<ContactDetail> ContactDetails { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }

        public DbSet<ApplicationGroup> ApplicationGroups { set; get; }
        //public DbSet<ApplicationRole> ApplicationRoles { set; get; }
        public DbSet<ApplicationGroupRole> ApplicationGroupRoles { set; get; }
        public DbSet<ApplicationUserGroup> ApplicationUserGroups { set; get; }

        //public DbSet<ApplicationUserRole> ApplicationUserRoles { set; get; }
        //public DbSet<ApplicationUserLogin> ApplicationUserLogins { set; get; }
        //public DbSet<ApplicationUserClaim> ApplicationUserClaims { set; get; }

        public static TeduShopDbContext Create()
        {
            return new TeduShopDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("ApplicationUserRoles");
            //builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("ApplicationUserLogins");
            ////builder.Entity<IdentityRole>().ToTable("ApplicationRoles");
            //builder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("ApplicationUserClaims");

            builder.Entity<ApplicationUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("ApplicationUserRoles");

            builder.Entity<ApplicationUserLogin>().HasKey(i => i.UserId).ToTable("ApplicationUserLogins");

            builder.Entity<ApplicationRole>().ToTable("ApplicationRoles");

            builder.Entity<ApplicationUserClaim>().HasKey(i => i.UserId).ToTable("ApplicationUserClaims");

            //builder.Entity<ApplicationGroup>()
            //    .HasMany<ApplicationUserGroup>((ApplicationGroup g) => g.ApplicationUsers)
            //    .WithRequired().HasForeignKey<string>((ApplicationUserGroup ag) => ag.GroupId);

            //builder.Entity<ApplicationUserGroup>()
            //    .HasKey((ApplicationUserGroup r) =>
            //        new
            //        {
            //            UserId = r.UserId,
            //            GroupId = r.GroupId
            //        }).ToTable("ApplicationUserGroups");

            //builder.Entity<ApplicationGroup>()
            //    .HasMany<ApplicationGroupRole>((ApplicationGroup g) => g.ApplicationRoles)
            //    .WithRequired().HasForeignKey<string>((ApplicationGroupRole ap) => ap.GroupId);

            //builder.Entity<ApplicationGroupRole>().HasKey((ApplicationGroupRole gr) =>
            //    new
            //    {
            //        RoleId = gr.RoleId,
            //        GroupId = gr.GroupId
            //    }).ToTable("ApplicationGroupRoles");
        }
    }
}
