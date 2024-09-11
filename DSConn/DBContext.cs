using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.DSConn
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().ToTable("Employee", "EmpDet");
            modelBuilder.Entity<Department>().ToTable("Department", "EmpDet");
            modelBuilder.Entity<Contract>().ToTable("Contract", "EmpDet");
            modelBuilder.Entity<Project>().ToTable("Project", "EmpDet");
            modelBuilder.Entity<Invoice>().ToTable("Invoice", "EmpDet");
            modelBuilder.Entity<LeaveRequest>().ToTable("LeaveRequest", "EmpDet");
           



        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }



    }
}