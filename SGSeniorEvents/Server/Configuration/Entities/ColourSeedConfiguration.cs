﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGSeniorEvents.Shared.Domain;

namespace SGSeniorEvents.Server.Configuration.Entities
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = 1,
                    Name = "Black",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Colour
                {
                Id = 2,
                Name = "Blue",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
                }
                );
        }
    }
}
