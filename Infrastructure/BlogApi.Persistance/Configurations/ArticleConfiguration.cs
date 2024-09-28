using BlogApi.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Persistance.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            Faker faker = new("tr");

            Article article = new()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Content = faker.Lorem.Sentence(100),
                TagId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            Article article2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Content = faker.Lorem.Sentence(70),
                TagId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            };
            builder.HasData(article,article2);
        }
    }
}
