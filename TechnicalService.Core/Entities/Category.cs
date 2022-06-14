using TechnicalService.Core.Entities.Abstracts;

namespace TechnicalService.Core.Entities;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }

    public IList<Brand>? Brands { get; set; }
}