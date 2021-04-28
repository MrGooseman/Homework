namespace Homework1.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Homework1.NewFolder1;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Client_Sales> Client_Sales { get; set; }
        public virtual DbSet<Sale_Items> Sale_Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Sale)
                .WithMany(e => e.Client)
                .Map(m => m.ToTable("Client_Sales"));

            modelBuilder.Entity<Item>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Sale)
                .WithMany(e => e.Item)
                .Map(m => m.ToTable("Sale_Items"));

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Client)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}

