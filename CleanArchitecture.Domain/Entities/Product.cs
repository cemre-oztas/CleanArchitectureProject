using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class Product : Entity
{
    public string Name { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
}
