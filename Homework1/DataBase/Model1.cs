namespace Homework1.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model19")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Sale_Item> Sale_Item { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Sale_Item)
                .WithMany(e => e.Client)
                .Map(m => m.ToTable("Client_Sale").MapRightKey("Sale_ID"));

            modelBuilder.Entity<Item>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Sale_Item)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.Item_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Client)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.User_ID);
        }
    }
}
