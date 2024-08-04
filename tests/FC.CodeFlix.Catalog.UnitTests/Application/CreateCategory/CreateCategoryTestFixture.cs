﻿using FC.CodeFlix.Catalog.UnitTests.Common;
using FC.CodeFlix.Catolog.Application.Interfaces;
using FC.CodeFlix.Catolog.Application.UseCases.Category.CreateCategory;
using FC.CodeFlix.Catolog.Domain.SeedWork;
using Moq;

namespace FC.CodeFlix.Catalog.UnitTests.Application.CreateCategory
{
    [CollectionDefinition(nameof(CreateCategoryTestFixture))]
    public class CreateCategoryTestFixtureCollection
        : ICollectionFixture<CreateCategoryTestFixture> { }

    public class CreateCategoryTestFixture : BaseFixture
    {
        public string GetValidCategoryName()
        {
            var categoryName = "";
            while (categoryName.Length < 3)
                categoryName = Faker.Commerce.Categories(1)[0];
            if (categoryName.Length > 255)
                categoryName = categoryName[..255];
            return categoryName;
        }

        public string GetValidCategoryDescription()
        {
            var categoryDescription = Faker.Commerce.ProductDescription();
            if (categoryDescription.Length > 10_000)
                categoryDescription = categoryDescription[..10_000];
            return categoryDescription;
        }

        public bool getRandomBoolean() => (new Random()).NextDouble() < 0.5;

        public CreateCategoryInput GetInput() =>
            new(GetValidCategoryName(), GetValidCategoryDescription(), getRandomBoolean());

        public Mock<ICategoryRepository> GetRepositoryMock() => new();

        public Mock<IUnitOfWork> GetUnitOfWorkMock() => new();
    }
}
