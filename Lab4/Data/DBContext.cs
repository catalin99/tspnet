using Microsoft.EntityFrameworkCore;
using ProjTspNet.Data;
using System;

namespace ModelAPI.Data
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyCode> PropertyCodes { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Movie movie = Movie.CreateMovie("/computer/location", "I am a legend", DateTime.Parse("07/06/1999"), "Festival", "Catalin", 30);

            modelBuilder.Entity<Movie>()
                .HasData(movie);

            Photo photo = Photo.CreatePhoto("/computer/location", "Me", DateTime.Parse("07/06/1999"), "Festival", "Catalin", 30, 50);

            modelBuilder.Entity<Photo>()
                .HasData(photo);

            User user = User.CreateUser("Catalin", "Cosmin", "catalinbelu21@gmail.com", "parolagrea", "0770796616", "Iasi");

            modelBuilder.Entity<User>()
                .HasData(user);

            Property prop = Property.CreateProperty(Guid.NewGuid(), Guid.NewGuid(), "43cm");

            modelBuilder.Entity<Property>()
                .HasData(prop);

            PropertyCode propCode = PropertyCode.CreatePropertyCode("3D diam");
            modelBuilder.Entity<PropertyCode>()
                .HasData(propCode);
        }

    }
}
