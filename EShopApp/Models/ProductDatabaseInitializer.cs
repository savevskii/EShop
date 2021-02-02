using System.Collections.Generic;
using System.Data.Entity;

namespace EShopApp.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Laptops"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "TV & Video"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Mobile Phones"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Photography & Videography"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Headphones"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Dell Inspiron",
                    Description = "Dell Inspiron is a Windows 10 laptop with a 15.60-inch display that has a resolution of 1920x1080 pixels. It is powered by a APU Quad Core A6 processor and it comes with 8GB of RAM. The Dell Inspiron packs 1TB of HDD storage. Graphics are powered by Nvidia GeForce GTX 1050.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6426/6426705_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 690.50,
                    IsOnSale = true,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Lenovo Yoga",
                    Description = "Lenovo Yoga (stylized as Lenovo YOGA or simply YOGΛ) is a line of consumer-oriented laptop computers and tablets designed, developed and marketed by Lenovo, named for their ability to assume multiple form factors due to a hinged screen.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6426/6426705_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 350.95,
                    IsOnSale = true,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Asus Rog",
                    Description = "The ROG Phone is a gaming smartphone launched by Asus. It sports a 6-inch AMOLED display with a 90Hz refresh rate and an FHD+ resolution. Powering the ROG Phone is a specially binned Qualcomm Snapdragon 845 SoC that has a higher clock speed of 2.96GHz. It has 8GB RAM and 128GB of storage which is non-expandable.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6403/6403816_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 950.00,
                    IsOnSale = false,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Apple Macbook Pro",
                    Description = "Apple MacBook Pro is a macOS laptop with a 13.30-inch display that has a resolution of 2560x1600 pixels. It is powered by a Core i5 processor and it comes with 12GB of RAM. The Apple MacBook Pro packs 512GB of SSD storage.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6418/6418601_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 1300.99,
                    IsOnSale = false,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "HP Spectre",
                    Description = "HP Spectre X360 is a Windows 10 Professional laptop with a 13.30-inch display that has a resolution of 1920x1080 pixels. It is powered by a Core i7 processor and it comes with 8GB of RAM. The HP Spectre X360 packs 256GB of SSD storage. Graphics are powered by Intel Integrated UHD Graphics 620.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6428/6428658_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 250.95,
                    IsOnSale = true,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Samsung",
                    Description = "Samsung’s legacy of game-changing innovations pushes the limit of what’s possible in picture and sound, delivering tomorrow's advancements to today's TVs. TVs so advanced, they turn a living room into a cinema, a backyard into a stadium, or transform into art that stands out by blending in. Our latest, industry-leading lineup isn't just built for the way you watch, but the way you live.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6402/6402399_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 850.00,
                    IsOnSale = true,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Sony",
                    Description = "Sony, as a TV company, is a pioneer of motion features, and it shows. They usually have the best interpolation, and most of their TVs have an image flicker feature to enhance motion clarity. Great upscaling. Sony TVs, even the cheaper models, do better than average when it comes to upscaling lower-resolution content.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6401/6401203_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 650.95,
                    IsOnSale = false,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Samsung S20",
                    Description = "The phone comes with a 6.20-inch touchscreen display with a resolution of 1440x3200 pixels and an aspect ratio of 20:9. Samsung Galaxy S20 is powered by a 2GHz octa-core Samsung Exynos 990 processor that features 2 cores clocked at 2.73GHz, 2 cores clocked at 2.5GHz and 4 cores clocked at 2GHz.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6426/6426301_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 900.50,
                    IsOnSale = false,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "iPhone 12",
                    Description = "The iPhone 12 features a 6.1-inch (15.3-cm) display with Super Retina XDR OLED technology at a resolution of 2532×1170 pixels and a pixel density of about 460 ppi. The iPhone 12 Mini features a 5.4-inch display with the same technology at a resolution of 2340×1080 pixels and a pixel density of about 476 ppi.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6009/6009969_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 1050.95,
                    IsOnSale = true,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Samsung Note 20",
                    Description = "The phone comes with a 6.70-inch touchscreen display with a resolution of 1080x2400 pixels and an aspect ratio of 20:9. Samsung Galaxy Note 20 is powered by a 2.4GHz octa-core Samsung Exynos 990 processor that features 4 cores clocked at 2.4GHz and 4 cores clocked at 1.8GHz. It comes with 8GB of RAM.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6422/6422216_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 1300.00,
                    IsOnSale = true,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Google Pixel 5",
                    Description = "The phone comes with a 6.00-inch touchscreen display with a resolution of 1080x2340 pixels at a pixel density of 432 pixels per inch (ppi) and an aspect ratio of 19.5:9. Google Pixel 5 is powered by a 1.8GHz octa-core Qualcomm Snapdragon 765G processor. It comes with 8GB of RAM.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6431/6431992_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 550.00,
                    IsOnSale = false,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Sony Alpha a7",
                    Description = "The Sony Alpha 7 is a full-frame E-mount mirrorless camera. The A7 is very similar to its more expensive sibling (the A7R), except that it uses a 24 megapixel CMOS sensor with on-chip phase detection. The A7 twins are the smallest and lightest full-frame cameras on the market.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6213/6213100_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 450.00,
                    IsOnSale = false,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Canon EO6 R6",
                    Description = "High Image Quality featuring a 20 Megapixel Full-frame CMOS Sensor. Featuring a Canon-developed 35mm full-frame CMOS sensor with approx. 20 effective megapixels, the EOS R6 camera is engineered with an imaging system, designed to capture sharp and detailed images, even in low-light scenarios.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6420/6420365_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 650.99,
                    IsOnSale = true,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Nikon Z50",
                    Description = "The Nikon Z50 is a compact mirrorless camera with an APS-C sensor (known as DX-format in Nikon-speak) that uses the company's Z-mount. It uses a 20.9MP BSI CMOS sensor (derived from the D500's) with on-sensor phase detection, but not in-body image stabilization like the full-frame Z6 and Z7.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6385/6385414_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 450.95,
                    IsOnSale = true,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Beats by Dr. Dre",
                    Description = "Dre (Beats) is a leading audio brand founded in 2006 by Dr. Dre and Jimmy Iovine. Through its family of premium consumer headphones, earphones and speakers, Beats has introduced an entirely new generation to the possibilities of premium sound entertainment.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6383/6383124_sd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 150.95,
                    IsOnSale = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Sony WH-CH510",
                    Description = "The WH-CH510 are wireless, lightweight, and have a battery life long enough to keep up with you. Listen to your favorite tracks wirelessly with a Bluetooth® wireless technology by pairing your smartphone or tablet. With up to 35 hours of battery life, you'll have enough power for even long trips away.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6359/6359775_rd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 122.95,
                    IsOnSale = false,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "JAM",
                    Description = "Jam Transit Touch True Definition Wireless Headphones provide a wireless connection to your iPhone, iPad, Android, smart phone, and other favorite Bluetooth-enabled electronic devices. ... Hands free calling works with your smartphone or connected tablet. Up to 12 Hours Play Time.",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6277/6277504_rd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 50.99,
                    IsOnSale = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "eKids - Marvel Spider-Man",
                    Description = "High Quality Stereo Sound Quality: Let your child enjoy high quality sound while being able to have good protection and not harming your kids hearing",
                    ImagePath="https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6351/6351560_rd.jpg;maxHeight=640;maxWidth=550",
                    UnitPrice = 50.95,
                    IsOnSale = false,
                    CategoryID = 5
                }

            };

            return products;
        }
    }
}