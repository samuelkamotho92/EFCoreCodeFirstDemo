using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;


namespace EFCoreCodeFirstDemo.Entities
{
    public class SMSCoreDbContext : DbContext
    {
        //Constructor calling the Base DbContext Class Constructor
        public SMSCoreDbContext() : base()
        {

        }

        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //use this to configure the contex
         //  optionsBuilder.UseSqlServer(@"Server=DESKTOP-KE6NN2R;Database=EFCoreDB1;Trusted_Connection=True;TrustServerCertificate=True;");
            //load configuration file
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            // Step3: Get the Section to Read from the Configuration File
            var configSection =  configBuilder.GetSection("ConnectionStrings");

            // Step4: Get the Configuration Values based on the Config key
            var connectionString = configSection["SQLServerConnection"] ?? null;

            //Configuring the Connection String
            optionsBuilder.UseSqlServer(connectionString);

        }

        //OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model

  
           
        }
        //pass the domain classes
        public DbSet<Student> Students{get;set; }
        public DbSet<Course> Courses { get;set; }

        public DbSet<Department> Departments { get;set; }

        public DbSet<Enrollment> Enrollments { get;set; }

        public DbSet<Professor> Professors { get;set; }
    }
}
