using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Email).IsRequired();
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Name);
            builder.Property(u => u.Image);
            builder.Property(u => u.Password);
            builder.Property(u => u.CompanyName);
            builder.Property(u => u.Position);
            builder.Property(u => u.Active).HasDefaultValue(true);
        }
    }
}
