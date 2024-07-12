using DomainEntity = FC.CodeFlix.Catalog.Domain.Entity;
namespace FC.Catalog.UnitTests.Domain.Entities.Category;


public class CategoryTests
{
    [Fact(DisplayName = nameof(Instantiate))]
    [Trait("Domain", "Category - Aggregates")]
    public void Instantiate()
    {
        // Arrange
        var validData = new
        {
            Name = "Category Name",
            Description = "Category Description"
        };

        // Act
        var category = new DomainEntity.Category(validData.Name, validData.Description);

        // Assert
        Assert.NotNull(category);
        Assert.Equal(validData.Name, category.Name);
        Assert.Equal(validData.Description, category.Description);
    }
}
