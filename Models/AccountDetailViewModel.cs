namespace DATN.Models;

public sealed class AccountDetailViewModel
{
    public required string Id { get; init; }

    public required string Role { get; init; }

    public required string RoleLabel { get; init; }

    public required string FullName { get; init; }

    public required string Email { get; init; }

    public required string Phone { get; init; }

    public required string Status { get; init; }

    public required string Address { get; init; }

    public required DateTime JoinedAt { get; init; }

    public required DateTime LastLoginAt { get; init; }

    public int TotalOrders { get; init; }

    public decimal TotalSpent { get; init; }

    public required IReadOnlyList<string> Permissions { get; init; }

    public required IReadOnlyList<string> RecentActivities { get; init; }
}
