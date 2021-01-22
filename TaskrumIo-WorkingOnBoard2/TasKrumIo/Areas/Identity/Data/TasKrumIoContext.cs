using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TasKrumIo.Areas.Identity.Data;
using TasKrumIo.Models;

namespace TasKrumIo.Data
{
    public class TasKrumIoContext : IdentityDbContext<TasKrumIoUser>
    {
        public TasKrumIoContext(DbContextOptions<TasKrumIoContext> options)
            : base(options)
        {
        }
        public TasKrumIoContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("TasKrumIoContextConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<TasKrumIo.Models.Board> Board { get; set; }
        public DbSet<TasKrumIo.Models.BoardView> BoardView { get; set; }
        public DbSet<TasKrumIo.Models.Columns> Columns { get; set; }
        public DbSet<TasKrumIo.Models.Cards> Cards { get; set; }

        public DbSet<TasKrumIo.Models.CardContents> CardContents { get; set; }
    }
}
