namespace DATN.Models;

public sealed class PageHeaderViewModel
{
    public required string Eyebrow { get; init; }

    public required string Title { get; init; }

    public string? Description { get; init; }
}
