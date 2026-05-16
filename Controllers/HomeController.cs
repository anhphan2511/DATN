using DATN.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DATN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Categories = new[]
                {
                    new CategoryCardViewModel { Name = "Quần áo nam", Description = "Áo thun, sơ mi, jeans và outerwear để mặc mỗi ngày.", Label = "Nam", Href = "#categories", ImageUrl = "/images/demo/category-men.svg", AccentClass = "bg-slate-950 text-white" },
                    new CategoryCardViewModel { Name = "Quần áo nữ", Description = "Váy, áo kiểu, quần dài và set đồ thanh lịch, dễ phối.", Label = "Nữ", Href = "#categories", ImageUrl = "/images/demo/category-women.svg", AccentClass = "bg-rose-50 text-rose-700" },
                    new CategoryCardViewModel { Name = "Giày sneaker", Description = "Giày tối giản, đế êm và hợp nhiều phong cách.", Label = "Giày", Href = "#categories", ImageUrl = "/images/demo/category-sneaker.svg", AccentClass = "bg-brand-50 text-brand-700" },
                    new CategoryCardViewModel { Name = "Dép và phụ kiện", Description = "Dép casual, túi, mũ và phụ kiện hoàn thiện outfit.", Label = "Phụ kiện", Href = "#categories", ImageUrl = "/images/demo/category-accessories.svg", AccentClass = "bg-amber-50 text-amber-700" }
                },
                FeaturedProducts = new[]
                {
                    new ProductCardViewModel { Name = "Áo thun boxy cao cấp", Description = "Cotton dày dặn, form boxy hiện đại, dễ mặc quanh năm.", Price = "329.000 VND", OriginalPrice = "429.000 VND", Badge = "Giảm giá", ImageLabel = "Áo thun boxy", ImageUrl = "/images/demo/product-tee.svg" },
                    new ProductCardViewModel { Name = "Sơ mi linen nghỉ dưỡng", Description = "Linen mềm nhẹ, thoáng mát cho đi làm và du lịch.", Price = "579.000 VND", Badge = "Mới", ImageLabel = "Linen", ImageUrl = "/images/demo/product-shirt.svg" },
                    new ProductCardViewModel { Name = "Quần jeans ống đứng xanh", Description = "Denim đứng form, wash xanh cổ điển, tôn dáng.", Price = "749.000 VND", ImageLabel = "Denim", ImageUrl = "/images/demo/product-jeans.svg" },
                    new ProductCardViewModel { Name = "Sneaker court tối giản", Description = "Đế êm, thân giày trắng tối giản, phối được mọi outfit.", Price = "990.000 VND", OriginalPrice = "1.290.000 VND", Badge = "Bán chạy", ImageLabel = "Giày sneaker", ImageUrl = "/images/demo/product-sneaker.svg" }
                },
                Benefits = new[]
                {
                    new HomeBenefitViewModel { Title = "Đổi size 7 ngày", Description = "Hỗ trợ đổi size nếu sản phẩm còn tem mác." },
                    new HomeBenefitViewModel { Title = "Miễn phí vận chuyển từ 499K", Description = "Áp dụng cho đơn hàng nội thành và toàn quốc." },
                    new HomeBenefitViewModel { Title = "COD và online", Description = "Linh hoạt thanh toán khi nhận hàng hoặc online." },
                    new HomeBenefitViewModel { Title = "Hàng mới mỗi tuần", Description = "Cập nhật nhanh các mẫu đang được yêu thích." }
                },
                Collections = new[]
                {
                    new HomeCollectionViewModel { Label = "Công sở thường ngày", Title = "Linen, denim và sneaker trắng", Description = "Set đồ sáng gọn cho đi làm, gặp gỡ bạn bè và những ngày cần lịch sự nhưng vẫn thoải mái.", Href = "#featured", ImageUrl = "/images/demo/collection-office.svg" },
                    new HomeCollectionViewModel { Label = "Cuối tuần", Title = "Áo boxy, quần rộng và dép thường ngày", Description = "Phong cách thư giãn cho cuối tuần với form rộng, chất liệu mềm và phụ kiện tối giản.", Href = "#featured", ImageUrl = "/images/demo/collection-weekend.svg", CardClass = "bg-gradient-to-br from-slate-950 via-slate-800 to-brand-700 text-white sm:translate-y-8" }
                }
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
