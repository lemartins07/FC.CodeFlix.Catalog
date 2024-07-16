using DomainEntity = FC.CodeFlix.Catalog.Domain.Entity;

namespace FC.CodeFlix.Catalog.UnitTests.Domain.Entity.Category;

public class CategoryTestFixture
{
    public DomainEntity.Category GetValidCategory() => new DomainEntity.Category("Category Name", "Category Description");    
}

[CollectionDefinition(nameof(CategoryTestFixture))]
public class CategoryTestFixtureCollection: ICollectionFixture<CategoryTestFixture> 
{ }

