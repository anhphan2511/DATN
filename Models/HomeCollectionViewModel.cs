namespace DATN.Models;

public sealed class HomeCollectionViewModel
{
    public required string Label { get; init; }

    public required string Title { get; init; }

    public required string Description { get; init; }

    public required string Href { get; init; }

    public string? ImageUrl { get; init; }

    public string CardClass { get; init; } = "bg-gradient-to-br from-stone-200 via-white to-stone-100 text-slate-950";
}
