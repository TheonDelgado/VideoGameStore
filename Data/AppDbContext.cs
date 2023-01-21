using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.Models;

namespace VideoGameStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors_Movies>().HasKey(am => new {
                am.ActorId, 
                am.MovieId
            });

            modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
            modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actors_Movies> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        
        public DbSet<Producer> Producers { get; set; }
    }
}