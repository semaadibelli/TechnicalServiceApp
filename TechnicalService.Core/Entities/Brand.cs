using TechnicalService.Core.Entities.Abstracts;

namespace TechnicalService.Core.Entities;

public class Brand : BaseEntity<int>
{
    public string Name { get; set; }
    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}