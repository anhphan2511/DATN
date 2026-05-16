using DATN.Models;
using Microsoft.AspNetCore.Mvc;

namespace DATN.Controllers;

public sealed class AccountController : Controller
{
    private static readonly IReadOnlyDictionary<string, AccountDetailViewModel> DemoAccounts =
        new Dictionary<string, AccountDetailViewModel>(StringComparer.OrdinalIgnoreCase)
        {
            ["customer"] = new AccountDetailViewModel
            {
                Id = "CUS-0001",
                Role = "customer",
                RoleLabel = "Khách hàng",
                FullName = "Nguyễn Minh Anh",
                Email = "khachhang@datnwear.vn",
                Phone = "0901 234 567",
                Status = "Đang hoạt động",
                Address = "24 Nguyễn Trãi, Quận 1, TP. Hồ Chí Minh",
                JoinedAt = new DateTime(2025, 10, 12, 9, 30, 0),
                LastLoginAt = new DateTime(2026, 5, 16, 8, 15, 0),
                TotalOrders = 8,
                TotalSpent = 4_680_000,
                Permissions = new[]
                {
                    "Xem và cập nhật thông tin cá nhân",
                    "Quản lý địa chỉ giao hàng",
                    "Theo dõi đơn hàng",
                    "Viết đánh giá sản phẩm đã mua"
                },
                RecentActivities = new[]
                {
                    "Đặt đơn #DH-1028 gồm áo thun boxy và sneaker court",
                    "Cập nhật địa chỉ giao hàng mặc định",
                    "Đánh giá 5 sao cho Sơ mi linen nghỉ dưỡng"
                }
            },
            ["admin"] = new AccountDetailViewModel
            {
                Id = "ADM-0001",
                Role = "admin",
                RoleLabel = "Quản trị viên",
                FullName = "Trần Quốc Bảo",
                Email = "admin@datnwear.vn",
                Phone = "0988 765 432",
                Status = "Đang hoạt động",
                Address = "Văn phòng DATN Wear, Quận Cầu Giấy, Hà Nội",
                JoinedAt = new DateTime(2025, 7, 1, 8, 0, 0),
                LastLoginAt = new DateTime(2026, 5, 16, 9, 5, 0),
                TotalOrders = 0,
                TotalSpent = 0,
                Permissions = new[]
                {
                    "Quản lý sản phẩm và biến thể size, màu",
                    "Quản lý danh mục quần áo, giày dép và phụ kiện",
                    "Xác nhận và cập nhật trạng thái đơn hàng",
                    "Quản lý khách hàng, khuyến mãi, thống kê và báo cáo"
                },
                RecentActivities = new[]
                {
                    "Cập nhật tồn kho cho Sneaker court tối giản",
                    "Xác nhận đơn hàng #DH-1031",
                    "Tạo mã khuyến mãi DATN50 cho chương trình giữa mùa"
                }
            }
        };

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Details(string type = "customer")
    {
        if (!DemoAccounts.TryGetValue(type, out var account))
        {
            return NotFound();
        }

        return View(account);
    }
}
