using StudentiProject.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;
using StudentiProject.Extensions;
using System;

namespace StudentiProject.DB
{
    public class StudentiProjectContext : DbContext
    {
        public StudentiProjectContext(DbContextOptions<StudentiProjectContext> options)
            : base(options)
        { }

        public DbSet<City> Cities { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Executor> Executors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ...

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);

            // many-to-many for 
            // relationship is: client - saving - bank

            modelBuilder.Entity<Executor>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.Executors)
                .HasForeignKey(sc => sc.CourseId);


            modelBuilder.Entity<Executor>()
                .HasOne<Teacher>(sc => sc.Teacher)
                .WithMany(s => s.Executors)
                .HasForeignKey(sc => sc.TeacherId);

            modelBuilder.Entity<Grade>()
               .HasOne<Course>(sc => sc.Course)
               .WithMany(s => s.Grades)
               .HasForeignKey(sc => sc.CourceId);


            modelBuilder.Entity<Grade>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(sc => sc.StudentId);



            // seed data from Extensions/Seeds.cs
            modelBuilder.Seed();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.Entity is BaseModel)
                {
                    var now = DateTime.UtcNow;
                    BaseModel entity = (BaseModel)entry.Entity;
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            entity.UpdatedAt = now;
                            break;
                        case EntityState.Added:
                            entity.CreatedAt = now;
                            break;
                    }
                }
            }
        }








    }



    
}