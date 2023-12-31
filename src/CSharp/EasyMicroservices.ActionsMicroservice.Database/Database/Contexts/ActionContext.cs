﻿using EasyMicroservices.ActionsMicroservice.Database.Entities;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.ActionsMicroservice.Database.Contexts
{
    public class ActionContext : RelationalCoreContext
    {
        IDatabaseBuilder _builder;
        public ActionContext(IEntityFrameworkCoreDatabaseBuilder builder) : base(builder)
        {
        }

        public DbSet<ViewEntity> Views { get; set; }
        public DbSet<LikeEntity> Likes { get; set; }
        public DbSet<FollowEntity> Follows { get; set; }
        public DbSet<FavoriteEntity> Favorites { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_builder != null)
                _builder.OnConfiguring(optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ViewEntity>(model =>
            {
                model.HasKey(x => x.Id);
            });

            modelBuilder.Entity<LikeEntity>(model =>
            {
                model.HasKey(x => x.Id);
            });

        }
    }
}