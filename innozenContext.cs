using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Test_web_1.Models;

namespace Test_web_1.Models
{
    public partial class innozenContext : DbContext
    {
        public innozenContext()
        {
        }

        public innozenContext(DbContextOptions<innozenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registration> RegisterData { get; set; } 
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                    //optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=innozen;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Registration");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Username).HasColumnName("username");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.FullName).HasColumnName("full_name");

                entity.Property(e => e.BadgeNum).HasColumnName("badge_num");

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.ManagerName).HasColumnName("manager_name");

                entity.Property(e => e.Email).HasColumnName("email");
            });


            modelBuilder.Entity<Ideas>(entity =>
            {
                entity.HasKey(e => e.Ideas_Id);

                entity.ToTable("Ideas");

                entity.Property(e => e.Ideas_Id).HasColumnName("ideas_id");

                entity.Property(e => e.Full_Name).HasColumnName("full_name");

                entity.Property(e => e.Manager_Name).HasColumnName("manager_name");

                entity.Property(e => e.Problem).HasColumnName("problem");

                entity.Property(e => e.Cause).HasColumnName("cause");

                entity.Property(e => e.Solution).HasColumnName("solution");


            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.Feedback_Id);

                entity.ToTable("Feedback");

                entity.Property(e => e.Feedback_Id).HasColumnName("feedback_id");

                entity.Property(e => e.Full_Name).HasColumnName("full_name");

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.Comment).HasColumnName("comment");


            });


            OnModelCreatingPartial(modelBuilder);
        }

      

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



        public DbSet<Test_web_1.Models.Ideas>? Ideas { get; set; }



        public DbSet<Test_web_1.Models.Feedback>? Feedback { get; set; }
        public IEnumerable<object> Registration { get; internal set; }
    }
}
