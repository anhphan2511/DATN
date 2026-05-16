namespace DATN.Models;

public sealed class HomeIndexViewModel
{
    public required IReadOnlyList<CategoryCardViewModel> Categories { get; init; }

    public required IReadOnlyList<ProductCardViewModel> FeaturedProducts { get; init; }

    public required IReadOnlyList<HomeBenefitViewModel> Benefits { get; init; }

    public required IReadOnlyList<HomeCollectionViewModel> Collections { get; init; }
}
