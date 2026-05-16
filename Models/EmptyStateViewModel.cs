namespace DATN.Models;

public sealed class EmptyStateViewModel
{
    public required string Title { get; init; }

    public required string Description { get; init; }

    public string? ActionText { get; init; }

    public string? ActionHref { get; init; }
}
