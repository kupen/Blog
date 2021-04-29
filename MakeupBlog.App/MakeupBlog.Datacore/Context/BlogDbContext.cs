using MakeupBlog.Datacore.Mapping;
using MakeupBlog.Domain.Models;
using System;
using System.Data.Entity;

namespace MakeupBlog.Datacore.Context
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base ("name = CstrBlog")
        {
            Configuration.LazyLoadingEnabled = false;

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("nvarchar"));
            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime2"));

            modelBuilder.Configurations.Add(new ArticleImageMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new MasterCategoryMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
            //base.OnModelCreating(modelBuilder); 
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleImage> ArticleImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MasterCategory> MasterCategories { get; set; }
    }
}
