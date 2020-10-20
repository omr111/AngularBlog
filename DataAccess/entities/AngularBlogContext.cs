using System;
using Entities.conc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

        public virtual DbSet<Adds> Adds { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<PostTag> PostTag { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<UserContactInfoes> UserContactInfoes { get; set; }
        public virtual DbSet<UserMessages> UserMessages { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=AngularBlog;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adds>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddName)
                    .HasColumnName("addName")
                    .HasMaxLength(110);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasIndex(e => e.PostId);

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

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.Property(e => e.DateOfSending).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).IsRequired();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<Likes>(entity =>
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

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.ToTable("logs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Audit).HasMaxLength(50);

                entity.Property(e => e.LogDate).HasColumnName("logDate");

                entity.Property(e => e.LogDetail).HasColumnName("logDetail");
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

            modelBuilder.Entity<Posts>(entity =>
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

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.Property(e => e.TagName)
                    .HasColumnName("tagName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserContactInfoes>(entity =>
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

            modelBuilder.Entity<UserMessages>(entity =>
            {
                entity.Property(e => e.DateOfSending).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId })
                    .HasName("PK_dbo.RoleUsers");

                entity.ToTable("userRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_Role_Id");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_User_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.RoleUsers_dbo.Roles_Role_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.RoleUsers_dbo.Users_User_Id");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

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

                entity.Property(e => e.UserName).HasColumnName("userName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
