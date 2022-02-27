using System;
using System.Collections.Generic;
using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataLayer
{
    internal partial class StudentManagementSystemContext : DbContext
    {
        public StudentManagementSystemContext()
        {
        }

        public StudentManagementSystemContext(DbContextOptions<StudentManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClassMaster> ClassMasters { get; set; } = null!;
        public virtual DbSet<ClassSubject> ClassSubjects { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<StaffKindMaster> StaffKindMasters { get; set; } = null!;
        public virtual DbSet<StaffMemberMaster> StaffMemberMasters { get; set; } = null!;
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; } = null!;
        public virtual DbSet<StudentClass> StudentClasses { get; set; } = null!;
        public virtual DbSet<StudentMaster> StudentMasters { get; set; } = null!;
        public virtual DbSet<StudentSubjectDetail> StudentSubjectDetails { get; set; } = null!;
        public virtual DbSet<SubjectMaster> SubjectMasters { get; set; } = null!;
        public virtual DbSet<UserMaster> UserMasters { get; set; } = null!;
        public virtual DbSet<Teacher> Teacher { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassMaster>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK__ClassMas__CB1927C0B2D0D4A5");

                entity.ToTable("ClassMaster");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClassSubject>(entity =>
            {
                entity.ToTable("Class_Subject");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AF2DBB992908E9D9");

                entity.ToTable("Employee");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<StaffKindMaster>(entity =>
            {
                entity.HasKey(e => e.StaffKindId)
                    .HasName("PK__StaffKin__494DA322C3442136");

                entity.ToTable("StaffKindMaster");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffMemberMaster>(entity =>
            {
                entity.HasKey(e => e.StaffMemberId)
                    .HasName("PK__StaffMem__2C1EBDC16F54351D");

                entity.ToTable("StaffMemberMaster");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.ToTable("StudentAddress");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.MobileNumber).HasColumnType("decimal(12, 0)");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentAddresses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_StudentAddress_StudentMaster");
            });

            modelBuilder.Entity<StudentClass>(entity =>
            {
                entity.ToTable("StudentClass");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentClass_ClassMaster");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentClasses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentClass_StudentMaster");
            });

            modelBuilder.Entity<StudentMaster>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("StudentMaster");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentSubjectDetail>(entity =>
            {
                entity.HasKey(e => e.StudentSubjectId)
                    .HasName("PK__StudentS__54F6B821C4BC96E6");

                entity.ToTable("StudentSubjectDetail");

                entity.Property(e => e.Percentage).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.ClassSubject)
                    .WithMany(p => p.StudentSubjectDetails)
                    .HasForeignKey(d => d.ClassSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentSubject_Class_Subject");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentSubjectDetails)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentSubject_StudentMaster");
            });

            modelBuilder.Entity<SubjectMaster>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.ToTable("SubjectMaster");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserMast__1788CC4C8B1E3F46");

                entity.ToTable("UserMaster");

                entity.HasIndex(e => e.UserName, "UQ__UserMast__C9F284562F577134")
                    .IsUnique();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.TeachedId);
                entity.ToTable("TeacherMaster");
                entity.Property(e => e.TeacherName)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TeacherAddress>(entity =>
            {
                entity.HasKey(e => e.TeacherAddressId);
                entity.ToTable("TeacherAddress");
                entity.Property(e => e.Address1)
                    .HasMaxLength(250);
                entity.Property(e => e.City)
                   .HasMaxLength(50);

                entity.HasOne(d => d.Teacher)
                .WithMany(p => p.TeacherAddress)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
