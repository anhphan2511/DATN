namespace DATN.Models;

public sealed class SectionHeaderViewModel
{
    public required string Title { get; init; }

    public string? Description { get; init; }

    public string? ActionText { get; init; }

    public string? ActionHref { get; init; }
}
