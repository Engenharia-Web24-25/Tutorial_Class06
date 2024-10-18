using System;
using System.Collections.Generic;
using Class06.Models;
using Microsoft.EntityFrameworkCore;

namespace Class06.Data;

public partial class Class06Context : DbContext
{
    public Class06Context()
    {
    }

    public Class06Context(DbContextOptions<Class06Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("name=Class06Context");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Class>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Class__3214EC076CCDA59C");
    //    });

    //    modelBuilder.Entity<Student>(entity =>
    //    {
    //        entity.HasKey(e => e.Number).HasName("PK__Student__78A1A19C0221E2AF");

    //        entity.Property(e => e.Number).ValueGeneratedNever();

    //        entity.HasOne(d => d.Class).WithMany(p => p.Students).HasConstraintName("FK__Student__ClassId__25869641");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
