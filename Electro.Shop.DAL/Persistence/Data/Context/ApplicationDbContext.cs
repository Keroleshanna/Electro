
namespace Electro.Shop.DAL.Persistence.Data.Context
{
    // Primary Constrictor is C# 12 .NET 8
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }


        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var entries = ChangeTracker.Entries<BaseAuditableEntity<int>>();

        //    foreach (var entry in entries)
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.Entity.CreatedById = 5; // ⚠️ مؤقتًا، حط هنا الـ userId الفعلي بعدين
        //                entry.Entity.CreatedOn = DateTime.UtcNow;
        //                break;

        //            case EntityState.Modified:
        //                entry.Entity.LastModifiedById = 5; // نفس الكلام
        //                entry.Entity.LastModifiedOn = DateTime.UtcNow;
        //                break;
        //        }

        //        if (entry.Entity.IsDeleted && entry.Entity.DeletedOn == null)
        //        {
        //            entry.Entity.DeletedById = 5; // الـ userId اللي حذف
        //            entry.Entity.DeletedOn = DateTime.UtcNow;
        //        }
        //    }

        //    return base.SaveChangesAsync(cancellationToken);
        //}

    }
}
