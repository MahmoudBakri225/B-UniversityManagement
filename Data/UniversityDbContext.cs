using System;
using System.Collections.Generic;
using B_UniversityManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Data;

public partial class UniversityDbContext : DbContext
{
    public UniversityDbContext()
    {
    }

    public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<Library> Libraries { get; set; }

    public virtual DbSet<Prof> Profs { get; set; }

    public virtual DbSet<ProfessorFaculty> ProfessorFaculties { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=University;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC07F40BA0B3");

            entity.HasOne(d => d.Library).WithMany(p => p.Books).HasConstraintName("FK__Books__Library_i__440B1D61");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Courses__3214EC07C6D258AD");

            entity.HasOne(d => d.Dept).WithMany(p => p.Courses).HasConstraintName("FK__Courses__Dept_id__49C3F6B7");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC0782B079B1");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Departments).HasConstraintName("FK__Departmen__Facul__412EB0B6");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07E78E871D");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Employees).HasConstraintName("FK__Employee__Facult__3E52440B");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Faculty__3214EC0749BC66D3");

            entity.HasOne(d => d.Library).WithMany(p => p.Faculties).HasConstraintName("FK__Faculty__Library__3B75D760");
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity.HasKey(e => e.FeeId).HasName("PK__Fees__B387B209F71340C0");

            entity.Property(e => e.FeeId).ValueGeneratedNever();

            entity.HasOne(d => d.Student).WithMany(p => p.Fees).HasConstraintName("FK__Fees__student_id__4CA06362");
        });

        modelBuilder.Entity<Library>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Library__3214EC0749802F67");
        });

        modelBuilder.Entity<Prof>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prof__3214EC07ABE58D98");

            entity.HasMany(d => d.Courses).WithMany(p => p.Professors)
                .UsingEntity<Dictionary<string, object>>(
                    "ProfessorCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Professor__Cours__5441852A"),
                    l => l.HasOne<Prof>().WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Professor__Profe__534D60F1"),
                    j =>
                    {
                        j.HasKey("ProfessorId", "CourseId").HasName("PK__Professo__AF9638568337BD07");
                        j.ToTable("Professor_Course");
                        j.IndexerProperty<int>("ProfessorId").HasColumnName("Professor_id");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_id");
                    });
        });

        modelBuilder.Entity<ProfessorFaculty>(entity =>
        {
            entity.HasKey(e => new { e.ProfessorId, e.FacultyId }).HasName("PK__Professo__39F0BDC63FF0E2D5");

            entity.HasOne(d => d.Faculty).WithMany(p => p.ProfessorFaculties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Professor__Facul__5070F446");

            entity.HasOne(d => d.Professor).WithMany(p => p.ProfessorFaculties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Professor__Profe__4F7CD00D");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC07C15556F1");

            entity.HasOne(d => d.Dept).WithMany(p => p.Students).HasConstraintName("FK__Student__Dept_id__46E78A0C");

            entity.HasMany(d => d.Books).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentBook",
                    r => r.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Student_B__Book___5BE2A6F2"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Student_B__Stude__5AEE82B9"),
                    j =>
                    {
                        j.HasKey("StudentId", "BookId").HasName("PK__Student___7ED5E10DC53D9D4F");
                        j.ToTable("Student_Books");
                        j.IndexerProperty<int>("StudentId").HasColumnName("Student_id");
                        j.IndexerProperty<int>("BookId").HasColumnName("Book_id");
                    });
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.CourseId }).HasName("PK__Student___8189DD683820F150");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Student_C__Cours__5812160E");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Student_C__Stude__571DF1D5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
