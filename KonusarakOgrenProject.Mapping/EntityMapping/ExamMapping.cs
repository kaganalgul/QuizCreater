﻿using KonusarakOgrenProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.Mapping.EntityMapping
{
    public class ExamMapping : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Questions).WithOne(x => x.Exam).HasForeignKey(x => x.ExamId);

            builder.HasOne(x => x.Article);

            builder.Property(x => x.ExamName).IsRequired();
        }
    }
}
