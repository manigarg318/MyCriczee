using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace cricZee
{
    public partial class UserAuthenticationContext : DbContext
    {
        public UserAuthenticationContext()
        {
        }

        public UserAuthenticationContext(DbContextOptions<UserAuthenticationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sign> Signs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:vsaitejaserver.database.windows.net,1433;Initial Catalog=UserAuthentication;Persist Security Info=False;User ID=vsaiteja;Password=Teja@199189;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sign>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__Sign__C5B69A4AEE86D0F6");

                entity.ToTable("Sign");

                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Upassword)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
