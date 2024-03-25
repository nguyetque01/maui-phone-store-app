using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MAUIAssignment
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, 
                    Title = "iPhone 15 Plus 512GB", 
                    Description = "Thiết kế dẫn đầu xu hướng - Nhiều màu sắc trendy cùng chất liệu kính pha màu và khung nhôm vô cùng bền bỉ\r\nNắm bắt và tương tác mọi thông tin dễ dàng hơn với Dynamic Island mở rộng\r\nChụp ảnh chân dung xuất sắc mọi khoảnh khắc - Camera chính 48MP với tele 2X và chế độ chỉnh sửa đa dạng\r\nHiệu năng cân mọi tác vụ - A16 Bionic mạnh mẽ cho mọi thao tác mượt mà và nhanh chóng\r\n", 
                    Price = 32490000,
                    Category = "Apple", 
                    Image = "product1.webp"
                },
                new Product { Id = 2,
                    Title = "Samsung Galaxy Fold5 12GB 1TB",
                    Description = "Thiết kế tinh tế với nếp gấp vô hình - Cải tiến nếp gấp thẩm mĩ hơn và gập không kẽ hở\r\nBền bỉ bất chấp mọi tình huống - Đạt chuẩn kháng bụi và nước IP68 cùng chất liệu nhôm Armor Aluminum giúp hạn chế cong và xước\r\nMở ra không gian giải trí cực đại với màn hình trong 7.6\" cùng bản lề Flex dẫn đầu công nghệ\r\nThoải mái sáng tạo mọi lúc - Bút Spen tiện dụng giúp bạn phác hoạ và ghi chép không cần đến sổ tay\r\nHiệu năng cân mọi tác vụ - Snapdragon® 8 Gen 2 for Galaxy xử lí mượt mà, đa nhiệm mượt mà",
                    Price = 47990000,
                    Category = "Samsung",
                    Image = "product2.webp"
                },
                new Product { Id = 3,
                    Title = "OPPO Reno11 F 5G 8GB 256GB",
                    Description = "OPPO Reno11 F 5G cung cấp trải nghiệm hiển thị, xử lý siêu mượt mà với màn hình AMOLED 6.7 inch hiện đại cùng chipset MediaTek Dimensity 7050 mạnh mẽ. Hệ thống quay chụp trên thế hệ Reno11 F 5G này được cải thiện hơn thông qua cụm 3 camera với độ phân giải lần lượt là 64MP, 8MP và 2MP. Ngoài ra, cung cấp năng lượng cho thế hệ OPPO smartphone này là viên pin 5000mAh cùng sạc nhanh 67W, mang tới trải nghiệm liền mạch suốt ngày dài.",
                    Price = 8990000,
                    Category = "OPPO",
                    Image = "product3.webp"
                },
            };
        }
    }
}
