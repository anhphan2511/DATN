namespace DATN.Models;

public sealed class ProductCardViewModel
{
    public required string Name { get; init; }

    public required string Description { get; init; }

    public required string Price { get; init; }

    public string? OriginalPrice { get; init; }

    public string? Badge { get; init; }

    public required string ImageLabel { get; init; }

    public string? ImageUrl { get; init; }

}
