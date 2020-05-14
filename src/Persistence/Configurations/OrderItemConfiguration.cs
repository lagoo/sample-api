﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                .ToTable("OrderItems");

            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Amount)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(e => e.Price)
                .IsRequired()
                .HasColumnType("float");
        }
    }
}
