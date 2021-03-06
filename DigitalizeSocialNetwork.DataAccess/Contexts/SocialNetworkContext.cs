﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalizeSocialNetwork.DomainModel.Entities;

namespace DigitalizeSocialNetwork.DataAccess.Contexts
{
    public class SocialNetworkContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PhotoAlbum> PhotoAlbums { get; set; }
        public DbSet<Photo> Photos { get; set; }
        //public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Post> Posts { get; set; }

        public SocialNetworkContext() 
            : base(DigitalizeSocialNetwork.DataAccess.
                  Properties.Settings.Default.DbConnectionString)
        {
            Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Friends)
                .WithMany()
                .Map(friendship =>
                {
                    friendship.MapLeftKey("FriendA");
                    friendship.MapRightKey("FriendB");
                    friendship.ToTable("Friendships");
                });
        }
    }
}
