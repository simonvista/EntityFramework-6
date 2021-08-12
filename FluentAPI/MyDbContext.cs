using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI
{
    class MyDbContext:DbContext
    {
        //public MyDbContext() : base("conStr")
        public MyDbContext():base("name=conStr")
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        //override OnModelCreating method in DbContext
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //entity config
            //ToTable -> config table name
            modelBuilder.Entity<Department>().ToTable("Dept");
            //HasKey
            modelBuilder.Entity<Department>().HasKey(dept => dept.DeptId);

            //property config for Employee entity
            //disable PK autoincrement by default
            modelBuilder.Entity<Employee>().Property(emp => emp.EmployeeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //chain the methods
            modelBuilder.Entity<Employee>().Property(emp => emp.EmpName).HasColumnName("EmployeeName")
                                                                        .IsRequired()
                                                                        .HasMaxLength(50)
                                                                        .HasColumnType("varchar");
            modelBuilder.Entity<Employee>().Property(emp => emp.PrimaryContact).IsRequired()
                                                                                .HasMaxLength(10);

            //set EmployeeId as PK
            modelBuilder.Entity<EmployeeAddress>().HasKey(adr => adr.EmployeeId);

            //model config (one-to-one relationship b/w Employee & EmployeeAddress entities)
            modelBuilder.Entity<Employee>().HasOptional(emp => emp.EmployeeAddress)
                                           .WithRequired(adr => adr.Employee);

            //model config (one-to-many relationship b/w Department & Employee entities)
            modelBuilder.Entity<Department>().HasMany(dpt => dpt.Employees)
                                             .WithRequired(emp => emp.Department)
                                            .HasForeignKey(emp=>emp.DepartmentId); 
            //model config (one-to-many relationship b/w Team & Employee entities)
            modelBuilder.Entity<Team>().HasMany(tm => tm.Employees)
                                        .WithOptional(em => em.Team)
                                        .HasForeignKey(em => em.TeamId);


        }
    }
}
