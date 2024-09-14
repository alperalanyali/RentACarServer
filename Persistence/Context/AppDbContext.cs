using System;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
	public class AppDbContext : IdentityDbContext<User,Role,Guid>
	{
		public AppDbContext()
		{
		}

		public AppDbContext(DbContextOptions<DbContext> options) : base(options)
		{

		}

        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarRequest> CarRequests { get; set; }
        public DbSet<CarPhoto> CarPhotos { get; set; }
        public DbSet<CarBranch> CarBranches { get; set; }
        public DbSet<KLog> KLogs { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<NavigationItem> NavigationItems { get; set;}
        public DbSet<NavigationItemRole> NavigationItemRoles { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }

        public DbSet<Payment> Payments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<IdentityUserLogin<Guid>>();
            builder.Ignore<IdentityUserRole<Guid>>();
            builder.Ignore<IdentityUserClaim<Guid>>();
            builder.Ignore<IdentityUserToken<Guid>>();
            builder.Ignore<IdentityRoleClaim<Guid>>();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=RentACarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Trusted_Connection=False;User ID=sa;Password=Metallica1;");
            }

        }
    }
}

