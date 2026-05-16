namespace DATN.Models;

public sealed class CategoryCardViewModel
{
    public required string Name { get; init; }

    public required string Description { get; init; }

    public required string Label { get; init; }

    public required string Href { get; init; }

    public string? ImageUrl { get; init; }

    public string AccentClass { get; init; } = "bg-brand-50 text-brand-700";
}
