using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products
{
    internal class ProductSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            if (!await context.SubCategories.AnyAsync(cancellationToken))
                return;

            if (await context.Products.AnyAsync(cancellationToken))
                return;

            Product[] products =
            {
                // ---------- MAN ----------
                // Clothes (SubCategoryId = 1)
                new() { Name = "Zara Slim Fit Cotton Shirt", Description = "A stylish slim-fit cotton shirt perfect for both casual and formal wear.", SubCategoryId = 1, Price = 549.99m, Brand = "Zara" , Stock= 3556,Size = "L", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "H&M Regular Fit Jeans", Description = "Classic denim jeans with a comfortable regular fit for everyday use.", SubCategoryId = 1, Price = 499.99m, Brand = "H&M", Stock= 3556,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new() { Name = "Levi’s 511 Slim Fit Denim", Description = "Authentic Levi’s jeans with a slim modern cut and durable denim fabric.", SubCategoryId = 1, Price = 699.99m, Brand = "Levi’s" , Stock= 3556,Size = "S", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Puma Essentials Logo Tee", Description = "Soft cotton T-shirt featuring the iconic Puma logo for a sporty look.", SubCategoryId = 1, Price = 299.99m, Brand = "Puma" , Stock= 3556,Size = "L", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Nike Sportswear Club Fleece Hoodie", Description = "Warm fleece hoodie providing everyday comfort and casual style.", SubCategoryId = 1, Price = 749.99m, Brand = "Nike" , Stock= 3556,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // Shoes (SubCategoryId = 2)
                new() { Name = "Nike Air Force 1 '07", Description = "Timeless basketball-inspired sneakers offering classic style and comfort.", SubCategoryId = 2, Price = 999.99m, Brand = "Nike" , Stock= 345656,Size = "L", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Adidas Stan Smith", Description = "Iconic leather sneakers known for their clean design and versatility.", SubCategoryId = 2, Price = 899.99m, Brand = "Adidas" , Stock= 345656,Size = "S", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Reebok Court Clean", Description = "Minimalist tennis-style shoes with premium leather and everyday comfort.", SubCategoryId = 2, Price = 849.99m, Brand = "Reebok", Stock= 345656,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Timberland 6-Inch Premium Boot", Description = "Durable waterproof boots made for tough conditions and urban style.", SubCategoryId = 2, Price = 1199.99m, Brand = "Timberland" , Stock= 345656,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Clarks Tilden Walk Oxford", Description = "Elegant leather oxford shoes ideal for formal or business occasions.", SubCategoryId = 2, Price = 749.99m, Brand = "Clarks" , Stock= 345656,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // Accessories (SubCategoryId = 3)
                new() { Name = "Casio G-Shock GA-2100", Description = "Shock-resistant digital-analog watch with bold design and durability.", SubCategoryId = 3, Price = 1199.99m, Brand = "Casio" , Stock= 96336,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Ray-Ban Original Wayfarer", Description = "Classic sunglasses offering iconic style and UV protection.", SubCategoryId = 3, Price = 999.99m, Brand = "Ray-Ban" , Stock= 96336,Size = "L", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Fossil Leather Wallet", Description = "Genuine leather wallet with multiple compartments for everyday use.", SubCategoryId = 3, Price = 299.99m, Brand = "Fossil" , Stock= 96336,Size = "s", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Hugo Boss Leather Belt", Description = "Premium leather belt with a sleek metal buckle for a polished finish.", SubCategoryId = 3, Price = 399.99m, Brand = "Hugo Boss" , Stock= 96336,Size = "s", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Diesel Stainless Steel Bracelet", Description = "Modern stainless steel bracelet that adds a rugged masculine edge.", SubCategoryId = 3, Price = 249.99m, Brand = "Diesel" , Stock= 96336,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // ---------- WOMAN ----------
                // Clothes (SubCategoryId = 4)
                new() { Name = "Zara Floral Midi Dress", Description = "Elegant floral print midi dress perfect for summer outings.", SubCategoryId = 4, Price = 699.99m, Brand = "Zara" , Stock= 934645,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "H&M Pleated Skirt", Description = "Light pleated skirt that moves beautifully with every step.", SubCategoryId = 4, Price = 399.99m, Brand = "H&M" , Stock= 934645,Size = "L", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Mango Satin Blouse", Description = "Smooth satin blouse ideal for both workwear and evening looks.", SubCategoryId = 4, Price = 349.99m, Brand = "Mango" , Stock= 934645,Size = "L", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Bershka High-Waist Trousers", Description = "Trendy high-waist trousers with a tailored modern silhouette.", SubCategoryId = 4, Price = 449.99m, Brand = "Bershka" , Stock= 934645,Size = "L", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Pull&Bear Oversized Denim Jacket", Description = "Casual oversized denim jacket with a relaxed vintage look.", SubCategoryId = 4, Price = 599.99m, Brand = "Pull&Bear" , Stock= 934645,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // Shoes (SubCategoryId = 5)
                new() { Name = "Aldo Stessy High Heel Pump", Description = "Classic pointed-toe heels that add elegance to any outfit.", SubCategoryId = 5, Price = 749.99m, Brand = "Aldo" , Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Charles & Keith Flat Loafers", Description = "Chic loafers offering style and comfort for daily wear.", SubCategoryId = 5, Price = 449.99m, Brand = "Charles & Keith" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Adidas Superstar", Description = "Timeless sneakers blending sporty design and street fashion.", SubCategoryId = 5, Price = 899.99m, Brand = "Adidas" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() {Name = "Zara Leather Ankle Boots", Description = "Stylish ankle boots crafted from soft genuine leather.", SubCategoryId = 5, Price = 899.99m, Brand = "Zara", Stock = 84234, Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Crocs Classic Clog", Description = "Lightweight clog shoes offering maximum comfort and breathability.", SubCategoryId = 5, Price = 299.99m, Brand = "Crocs" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // Bags (SubCategoryId = 6)
                new() { Name = "Michael Kors Jet Set Tote", Description = "Spacious tote bag crafted from premium saffiano leather.", SubCategoryId = 6, Price = 1099.99m, Brand = "Michael Kors" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Coach Tabby Shoulder Bag", Description = "Elegant leather shoulder bag with a modern structured design.", SubCategoryId = 6, Price = 1299.99m, Brand = "Coach" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Guess Downtown Backpack", Description = "Trendy faux-leather backpack for casual everyday wear.", SubCategoryId = 6, Price = 699.99m, Brand = "Guess" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Kate Spade All Day Tote", Description = "Minimalist tote with ample space and refined details.", SubCategoryId = 6, Price = 999.99m, Brand = "Kate Spade" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "H&M Crossbody Bag", Description = "Compact and versatile crossbody bag for everyday essentials.", SubCategoryId = 6, Price = 349.99m, Brand = "H&M" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // ---------- KIDS ----------
                // Clothes (SubCategoryId = 7)
                new() { Name = "Gap Kids Graphic Tee", Description = "Soft cotton T-shirt with fun graphics for active kids.", SubCategoryId = 7, Price = 199.99m, Brand = "Gap Kids" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "H&M Kids Slim Jeans", Description = "Comfortable stretch jeans designed for growing kids.", SubCategoryId = 7, Price = 249.99m, Brand = "H&M Kids" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Zara Kids Bomber Jacket", Description = "Trendy lightweight bomber jacket for cool-weather days.", SubCategoryId = 7, Price = 399.99m, Brand = "Zara Kids" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Nike Kids Club Shorts", Description = "Soft cotton shorts built for comfort and playtime.", SubCategoryId = 7, Price = 179.99m, Brand = "Nike" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Puma Kids Hoodie", Description = "Cozy hoodie featuring the Puma logo for a sporty everyday look.", SubCategoryId = 7, Price = 249.99m, Brand = "Puma" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // Shoes (SubCategoryId = 8)
                new() { Name = "Adidas Kids Runfalcon 3.0", Description = "Lightweight running shoes offering support for growing feet.", SubCategoryId = 8, Price = 399.99m, Brand = "Adidas" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Crocs Kids Classic Clog", Description = "Iconic clogs designed for kids—easy to wear, easy to clean.", SubCategoryId = 8, Price = 299.99m, Brand = "Crocs" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Nike Kids Revolution 6", Description = "Comfortable and durable running shoes for active children.", SubCategoryId = 8, Price = 449.99m, Brand = "Nike" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Puma Smash v2 Sneakers", Description = "Classic sneakers for kids offering great comfort and support.", SubCategoryId = 8, Price = 349.99m, Brand = "Puma" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Reebok Kids Royal Prime 2", Description = "Stylish everyday sneakers built for all-day play.", SubCategoryId = 8, Price = 379.99m, Brand = "Reebok" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
            
                // Toys (SubCategoryId = 9)
                new() { Name = "LEGO City Police Station", Description = "Exciting building set that sparks creativity and problem-solving.", SubCategoryId = 9, Price = 799.99m, Brand = "LEGO" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Barbie Dreamhouse Doll Set", Description = "Colorful dollhouse set offering endless imaginative play.", SubCategoryId = 9, Price = 999.99m, Brand = "Barbie" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Hot Wheels Ultimate Garage", Description = "Multi-level car garage for fun and fast racing adventures.", SubCategoryId = 9, Price = 899.99m, Brand = "Hot Wheels" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Play-Doh Modeling Compound Set", Description = "Creative modeling clay set for shaping and imaginative fun.", SubCategoryId = 9, Price = 199.99m, Brand = "Play-Doh" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Hasbro Nerf Elite Blaster", Description = "Soft dart blaster offering safe and action-packed play.", SubCategoryId = 9, Price = 299.99m, Brand = "Hasbro" ,Stock= 84234,Size = "M", CreatedById = 1, CreatedOn = DateTime.UtcNow}
            };

            foreach (var item in products)
                await context.Products.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);

        }
    }
}
