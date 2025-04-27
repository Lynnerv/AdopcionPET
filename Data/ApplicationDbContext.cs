﻿using AdopcionPET.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdopcionPET.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Adoptante> Adoptantes { get; set; }
    public DbSet<Adopcion> Adopciones { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Mascota>()
                .HasOne(m => m.Adopcion)
                .WithOne(a => a.Mascota)
                .HasForeignKey<Adopcion>(a => a.MascotaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Adopcion>()
                .HasOne(a => a.Adoptante)
                .WithMany(ad => ad.Adopciones)
                .HasForeignKey(a => a.AdoptanteId);
        }
}
