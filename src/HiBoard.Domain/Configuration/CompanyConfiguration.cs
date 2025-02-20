﻿using HiBoard.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace HiBoard.Domain.Configuration;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        #region Table Configuration

        builder.ToTable("companies");

        builder.HasQueryFilter(x => !x.IsDeleted);

        builder
            .Property(_ => _.Id)
            .HasColumnName("id");

        builder.HasKey(_ => _.Id);

        builder
            .Property(_ => _.Name)
            .HasColumnName("name")
            .HasMaxLength(150)
            .IsRequired();

        builder
            .Property(_ => _.Description)
            .HasColumnName("description")
            .HasMaxLength(4000);

        builder
            .Property(_ => _.Admin)
            .HasColumnName("admin")
            .HasMaxLength(50);

        builder
            .Property(_ => _.Departments)
            .HasColumnName("departments")
            .IsRequired();

        //builder
        //    .Property(_ => _.Users)
        //    .HasColumnName("users")
        //    .IsRequired();

        builder
            .Property(_ => _.CreatedAt)
            .HasColumnName("creation_at")
            .HasColumnType("DATETIME")
            .IsRequired();

        builder
            .Property(_ => _.UpdatedAt)
            .HasColumnName("updated_at")
            .HasColumnType("DATETIME")
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .HasColumnName("is_deleted")
            .HasColumnType("tinyint");

        #endregion

        #region Releationship Configuration

        builder.HasMany(company => company.Users)
            .WithOne(user => user.Company!)
            .HasForeignKey(user => user.CompanyId)
            .IsRequired();

        #endregion

        #region Convertion Configuration

        builder.Property(company => company.Departments).HasConversion(
            department => JsonConvert.SerializeObject(department),
            departments => JsonConvert.DeserializeObject<List<string>>(departments)!);

        #endregion
    }
}