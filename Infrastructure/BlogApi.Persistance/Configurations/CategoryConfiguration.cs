using BlogApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category = new()
            {
                Id = 1,
                CategoryName = "ASP.NET CORE",
                Priorty = 1,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };

            Category category2 = new()
            {
                Id = 2,
                CategoryName = "C#",
                Priorty = 2,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };
            Category parent = new()
            {
                Id = 3,
                CategoryName = "ASP.NET CORE 2.0",
                Priorty = 1,
                ParentId = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };

            Category parent2 = new()
            {
                Id = 4,
                CategoryName = "C# 6.0",
                Priorty = 1,
                ParentId = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };

            builder.HasData(category,category2,parent,parent2);

        }
    }
}
