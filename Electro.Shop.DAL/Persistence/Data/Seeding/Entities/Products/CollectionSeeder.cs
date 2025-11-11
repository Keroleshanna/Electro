using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products
{
    internal class CollectionSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            if (!await context.SubCategories.AnyAsync(cancellationToken))
                return;

            if (await context.Collections.AnyAsync(cancellationToken))
                return;

            Collection[] collections =
            {
                // Computers & Laptops
                new Collection() { Name = "Gaming Laptops", SubCategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "High-performance laptops designed for gaming and heavy graphics use." },
                new Collection() { Name = "Business Laptops", SubCategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Reliable laptops optimized for work, productivity, and business tasks." },
                new Collection() { Name = "Ultrabooks", SubCategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Slim, lightweight laptops with long battery life for everyday use." },
                new Collection() { Name = "Workstations", SubCategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Powerful laptops for professional tasks like CAD, video editing, and 3D modeling." },
                new Collection() { Name = "Chromebooks", SubCategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Affordable laptops running Chrome OS, ideal for browsing and cloud-based apps." },

                new Collection() { Name = "Gaming Desktops", SubCategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Desktop PCs optimized for gaming performance and custom setups." },
                new Collection() { Name = "All-in-One PCs", SubCategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Compact desktop PCs with integrated components in a single unit." },
                new Collection() { Name = "Mini PCs", SubCategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Small form-factor PCs for space-saving and light computing tasks." },
                new Collection() { Name = "PC Towers", SubCategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Traditional tower desktops with customizable components." },
                new Collection() { Name = "Custom Builds", SubCategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Build-your-own desktop PCs tailored to personal preferences and needs." },

                new Collection() { Name = "Gaming Monitors", SubCategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "High-refresh-rate monitors designed for smooth gaming experience." },
                new Collection() { Name = "4K Monitors", SubCategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Ultra-high-definition monitors for sharp visuals and professional work." },
                new Collection() { Name = "Ultrawide Monitors", SubCategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Wide-screen monitors for immersive gaming and multitasking." },
                new Collection() { Name = "Curved Monitors", SubCategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Curved monitors that enhance field of view and reduce eye strain." },
                new Collection() { Name = "Professional Monitors", SubCategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Color-accurate monitors for designers, photographers, and video editors." },
            
                // Mobile Phones & Accessories
                new Collection() { Name = "Flagship Smartphones", SubCategoryId = 4, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Top-tier smartphones with the latest features and performance." },
                new Collection() { Name = "Budget Smartphones", SubCategoryId = 4, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Affordable smartphones with essential features for everyday use." },
                new Collection() { Name = "Refurbished Phones", SubCategoryId = 4, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Certified pre-owned smartphones in excellent working condition." },
                new Collection() { Name = "Foldable Phones", SubCategoryId = 4, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Innovative foldable smartphones offering flexible screen designs." },
                new Collection() { Name = "5G Smartphones", SubCategoryId = 4, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Smartphones supporting 5G connectivity for faster internet speeds." },

                new Collection() { Name = "Fast Chargers", SubCategoryId = 5, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "High-speed chargers for quick device charging." },
                new Collection() { Name = "Wireless Chargers", SubCategoryId = 5, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Cord-free chargers compatible with wireless charging devices." },
                new Collection() { Name = "Charging Cables", SubCategoryId = 5, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Durable and reliable cables for charging and data transfer." },
                new Collection() { Name = "Power Adapters", SubCategoryId = 5, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Adapters for converting power to charge various devices." },
                new Collection() { Name = "Car Chargers", SubCategoryId = 5, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Chargers for use in vehicles to charge devices on the go." },

                new Collection() { Name = "Wireless Earbuds", SubCategoryId = 6, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Compact wireless earbuds for music and calls." },
                new Collection() { Name = "Over-Ear Headphones", SubCategoryId = 6, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Comfortable headphones for immersive audio experience." },
                new Collection() { Name = "Gaming Headsets", SubCategoryId = 6, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Headsets with microphone for gaming and communication." },
                new Collection() { Name = "Noise Cancelling Headphones", SubCategoryId = 6, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Headphones that block external noise for focused listening." },
                new Collection() { Name = "Sport Headphones", SubCategoryId = 6, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Durable and sweat-resistant headphones for workouts and sports." },
            
                // TV & Home Entertainment
                new Collection() { Name = "LED TVs", SubCategoryId = 7, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Bright and energy-efficient LED TVs with sharp visuals." },
                new Collection() { Name = "OLED TVs", SubCategoryId = 7, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "High-contrast OLED TVs for deep blacks and vivid colors." },
                new Collection() { Name = "Smart TVs", SubCategoryId = 7, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Internet-connected TVs for streaming apps and smart features." },
                new Collection() { Name = "4K TVs", SubCategoryId = 7, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Ultra-high-definition TVs for crystal-clear visuals." },
                new Collection() { Name = "Curved TVs", SubCategoryId = 7, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Curved screens that enhance viewing immersion." },

                new Collection() { Name = "Soundbars", SubCategoryId = 8, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Compact speaker systems for improved TV audio." },
                new Collection() { Name = "Home Theater Systems", SubCategoryId = 8, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Complete audio setups for immersive home cinema experience." },
                new Collection() { Name = "Bluetooth Speakers", SubCategoryId = 8, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Portable wireless speakers with Bluetooth connectivity." },
                new Collection() { Name = "Portable Speakers", SubCategoryId = 8, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Compact speakers for easy transport and outdoor use." },
                new Collection() { Name = "Surround Sound Systems", SubCategoryId = 8, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Multi-speaker setups for immersive surround sound at home." },

                new Collection() { Name = "Projectors for Home", SubCategoryId = 9, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Projectors ideal for home movie nights and entertainment." },
                new Collection() { Name = "Mini Projectors", SubCategoryId = 9, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Compact, portable projectors for easy setup and travel." },
                new Collection() { Name = "4K Projectors", SubCategoryId = 9, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "High-resolution projectors for ultra-clear images." },
                new Collection() { Name = "Portable Projectors", SubCategoryId = 9, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Lightweight projectors that can be used anywhere." },
                new Collection() { Name = "Business Projectors", SubCategoryId = 9, CreatedById = 1, CreatedOn = DateTime.UtcNow, Description = "Projectors designed for meetings, presentations, and offices." }
            };

            foreach (var item in collections)
                await context.Collections.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
