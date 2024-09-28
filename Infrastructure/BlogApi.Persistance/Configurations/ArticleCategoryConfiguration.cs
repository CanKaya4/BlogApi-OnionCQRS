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
    public class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.HasKey(p => new { p.ArticleId, p.CategoryId });

            builder.HasOne(a=>a.Article).WithMany(ac=>ac.ArticleCategories).HasForeignKey(ac=>ac.ArticleId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Category).WithMany(ac => ac.ArticleCategories).HasForeignKey(ac => ac.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
