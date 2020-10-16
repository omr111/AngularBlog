using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.entities
{
    public partial class AngularBlogContext : DbContext
    {
        public AngularBlogContext()
        {
        }

        public AngularBlogContext(DbContextOptions<AngularBlogContext> options)
            : base(options)
        {
        }

        public  DbSet<Add> Adds { get; set; }
        public  DbSet<Category> categories { get; set; }
        public  DbSet<Comment> Comments { get; set; }
        public  DbSet<Contact> Contacts { get; set; }
        public DbSet<Log> logs { get; set; }
        public  DbSet<Like> Likes { get; set; }
        public  DbSet<PostTag> PostTag { get; set; }
        public  DbSet<Post> Posts { get; set; }
        public  DbSet<userRole> userRoles { get; set; }
        public  DbSet<role> roles { get; set; }
        public  DbSet<Tag> Tags { get; set; }
        public  DbSet<UserContactInfo> UserContactInfoes { get; set; }
        public  DbSet<UserMessage> UserMessages { get; set; }
        public  DbSet<user> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=AngularBlog;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Add>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddName)
                    .HasColumnName("addName")
                    .HasMaxLength(110);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Comments_dbo.Posts_PostId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Comments_dbo.Users_UserId");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.DateOfSending).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).IsRequired();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Title).IsRequired();
            });


            modelBuilder.Entity<Like>(entity =>
            {
                entity.HasIndex(e => e.PostId)
                    .HasName("IX_PostId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LikedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Likes_dbo.Posts_PostId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Likes_dbo.Users_UserId");
            });

            modelBuilder.Entity<PostTag>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.TagId })
                    .HasName("PK_dbo.PostTag");

                entity.HasIndex(e => e.PostId)
                    .HasName("IX_Post_Id");

                entity.HasIndex(e => e.TagId)
                    .HasName("IX_Tag_Id");

                entity.Property(e => e.PostId).HasColumnName("Post_Id");

                entity.Property(e => e.TagId).HasColumnName("Tag_Id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostTag)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_dbo.PostTag_dbo.Posts_Post_Id");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.PostTag)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_dbo.PostTag_dbo.Tags_Tag_Id");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.BackgroundImgUrl).HasColumnName("BackgroundImgURL");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(300);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Posts_dbo.Categories_CategoryId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Posts_dbo.Users_UserId");
            });

            modelBuilder.Entity<userRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId })
                    .HasName("PK_dbo.RoleUsers");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_Role_Id");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_User_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.RoleUsers_dbo.Roles_Role_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RoleUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.RoleUsers_dbo.Users_User_Id");
            });

            modelBuilder.Entity<role>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagName)
                    .HasColumnName("tagName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserContactInfo>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LinkAddress).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserContactInfoes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserContactInfoes_dbo.Users_UserId");
            });

            modelBuilder.Entity<UserMessage>(entity =>
            {
                entity.Property(e => e.DateOfSending).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<user>(entity =>
            {
                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PasswordSalt).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(13);

                entity.Property(e => e.ProfileImgUrl).HasMaxLength(100);

                entity.Property(e => e.RegisteredDate).HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
