using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClothesShop
{
    public class ClothesShopInitializer : CreateDatabaseIfNotExists<ClothesShopContext>
        {
            protected override void Seed(ClothesShopContext context)
            {
             List<ClothingItem> clothes = new List<ClothingItem>();
             // Ladies clothes
             clothes.Add(new ClothingItem { Name = "Blue Stripe Print Short Sleeve Shirt", Type = "Ladies", Price = 22, Category = "Blouses & Shirts" });
             clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
             clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 69 });
             clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 36 });
             clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 21 });
             clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 50 });

            clothes.Add(new ClothingItem { Name = "Black Spot Print Midi Skirt", Type = "Ladies", Price = 26, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 30 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 81 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 37 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 27 });

            clothes.Add(new ClothingItem { Name = "Pink Midi Dress", Type = "Ladies", Price = 30, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 25 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 79 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 88 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 76 });

            clothes.Add(new ClothingItem { Name = "Pink Premium Sequin Smock Mini Dress", Type = "Ladies", Price = 59, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 23 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 59 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 2 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 99 });

            clothes.Add(new ClothingItem { Name = "Monochrome Balloon Sleeve Playsuit", Type = "Ladies", Price = 40, Category = "Playsuits & Jumpsuits" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 41 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 47 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 32 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 5 });

            clothes.Add(new ClothingItem { Name = "Pink Spotted Mesh Smock Midi Dress", Type = "Ladies", Price = 42, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 22 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 77 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 83 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 8 });

            clothes.Add(new ClothingItem { Name = "Multi Colour Floral Print Chiffon Wrap Fit And Flare Dress", Type = "Ladies", Price = 45, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 51 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 31 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 85 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 100 });

            clothes.Add(new ClothingItem { Name = "White Linen Blend Mix Jumpsuit", Type = "Ladies", Price = 35, Category = "Playsuits & Jumpsuits" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 33 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 72 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 82 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 65 });

            clothes.Add(new ClothingItem { Name = "Black Zebra Print Frill Chiffon Shift Dress", Type = "Ladies", Price = 30, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 80 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 49 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 24 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 43 });

            clothes.Add(new ClothingItem { Name = "Apricot Stripe Print Short Sleeve Shirt", Type = "Ladies", Price = 22, Category = "Blouses & Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 34 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 3 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 29 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 46 });

            clothes.Add(new ClothingItem { Name = "White Puff Sleeve Lace Top", Type = "Ladies", Price = 20, Category = "Blouses & Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 48 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 74 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 55 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 53 });

            clothes.Add(new ClothingItem { Name = "Pink Double Frill Bardot Dress", Type = "Ladies", Price = 30, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 44 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 10 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 75 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 52 });

            clothes.Add(new ClothingItem { Name = "Black Polka Dot Print Midi Skirt", Type = "Ladies", Price = 35, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 64 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 94 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 54 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 98 });

            clothes.Add(new ClothingItem { Name = "Blush Tulle Full Midi Skirt", Type = "Ladies", Price = 30, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 15 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 9 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 86 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 84 });

            clothes.Add(new ClothingItem { Name = "Lemon Organza Sleeve Top", Type = "Ladies", Price = 24, Category = "Blouses & Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 45 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 20 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 93 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 11 });

            clothes.Add(new ClothingItem { Name = "Ivory Broderie Shell Top", Type = "Ladies", Price = 24, Category = "Blouses & Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 91 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 58 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 62 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 1 });

            clothes.Add(new ClothingItem { Name = "Peach Embellished Neck Jumpsuit", Type = "Ladies", Price = 55, Category = "Playsuits & Jumpsuits" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 6 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 61 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 97 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 92 });

            clothes.Add(new ClothingItem { Name = "Yellow Ruffle Strappy Midi Dress", Type = "Ladies", Price = 45, Category = "Dresses & Skirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 26 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 39 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 13 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 14 });

            clothes.Add(new ClothingItem { Name = "Blue Dobby Button Front Shirt", Type = "Ladies", Price = 26, Category = "Blouses & Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 38 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 46 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 89 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 53 });

            clothes.Add(new ClothingItem { Name = "Black Spot Print Tie Front Jumpsuit", Type = "Ladies", Price = 30, Category = "Playsuits & Jumpsuits" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 35 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 12 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 63 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 28 });

            // Men's clothes
            clothes.Add(new ClothingItem { Name = "Navy Regular Fit Crew Neck T-Shirt", Type = "Mens", Price = 6, Category = "T-Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 56 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 96 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 67 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 68 });

            clothes.Add(new ClothingItem { Name = "White Slim Fit Crew Neck T-Shirt", Type = "Mens", Price = 6, Category = "T-Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 70 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 4 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 16 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 57 });

            clothes.Add(new ClothingItem { Name = "Navy Dip Dye Graphic Regular Fit T-Shirt", Type = "Mens", Price = 18, Category = "T-Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 73 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 66 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 60 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 40 });

            clothes.Add(new ClothingItem { Name = "Lyle & Scott Crew Neck T-Shirt", Type = "Mens", Price = 25, Category = "T-Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 90 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 7 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 18 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 42 });

            clothes.Add(new ClothingItem { Name = "Black Regular Fit Crew Neck T-Shirt", Type = "Mens", Price = 6, Category = "T-Shirts" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 95 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 92 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 69 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 79 });

            clothes.Add(new ClothingItem { Name = "Black Slim Fit Stretch Formal Trousers", Type = "Mens", Price = 22, Category = "Trousers" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 42 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 73 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 68 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 98 });

            clothes.Add(new ClothingItem { Name = "Tan Slim Fit Stretch Chinos", Type = "Mens", Price = 22, Category = "Trousers" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 82 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 23 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 30 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 64 });

            clothes.Add(new ClothingItem { Name = "Black Skinny Fit Stretch Formal Trousers", Type = "Mens", Price = 22, Category = "Trousers" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 59 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 84 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 90 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 62 });

            clothes.Add(new ClothingItem { Name = "Black Regular Fit Suit: Trousers", Type = "Mens", Price = 29, Category = "Trousers" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 29 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 9 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 91 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 58 });

            clothes.Add(new ClothingItem { Name = "Charcoal Tech Cargos", Type = "Mens", Price = 35, Category = "Trousers" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 96 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 37 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 81 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 72 });

            clothes.Add(new ClothingItem { Name = "Navy Slim Fit Blazer", Type = "Mens", Price = 58, Category = "Blazers & Formal Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 35 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 83 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 49 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 47 });

            clothes.Add(new ClothingItem { Name = "Blue Skinny Fit Check Suit: Jacket", Type = "Mens", Price = 84, Category = "Blazers & Formal Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 14 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 63 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 28 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 10 });

            clothes.Add(new ClothingItem { Name = "Joules Slim Fit Blazer", Type = "Mens", Price = 199, Category = "Blazers & Formal Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 38 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 33 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 1 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 100 });

            clothes.Add(new ClothingItem { Name = "Mid Blue Slim Fit Check Suit: Jacket", Type = "Mens", Price = 74, Category = "Blazers & Formal Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 74 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 45 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 56 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 46 });

            clothes.Add(new ClothingItem { Name = "Light Grey Slim Fit Textured Blazer", Type = "Mens", Price = 75, Category = "Blazers & Formal Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 18 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 36 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 51 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 88 });

            clothes.Add(new ClothingItem { Name = "The North Face® Quest Jacket", Type = "Mens", Price = 100, Category = "Coats & Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 85 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 50 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 24 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 41 });

            clothes.Add(new ClothingItem { Name = "Black Shower Resistant Hooded Jacket", Type = "Mens", Price = 65, Category = "Coats & Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 20 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 78 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 25 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 2 });

            clothes.Add(new ClothingItem { Name = "Charcoal Zip Epsom Coat", Type = "Mens", Price = 130, Category = "Coats & Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 8 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 11 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 95 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 67 });

            clothes.Add(new ClothingItem { Name = "Black Signature Leather Racer Jacket", Type = "Mens", Price = 150, Category = "Coats & Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 22 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 94 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 55 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 99 });

            clothes.Add(new ClothingItem { Name = "Grey Bomber Jacket", Type = "Mens", Price = 55, Category = "Coats & Jackets" });
            clothes[clothes.Count() - 1].ClothingSizes = new List<ClothingSize>();
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "S", Quantity = 77 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "M", Quantity = 65 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "L", Quantity = 86 });
            clothes[clothes.Count() - 1].ClothingSizes.Add(new ClothingSize { Size = "XL", Quantity = 4 });

            context.Users.Add(new User { Address = "UNKNOWN", Email = "UNKNOWN", Name = "UNKNOWN", Surname = "UNKNOWN", UserName = "UNKNOWN" });
            context.ClothingItems.AddRange(clothes);
            }
        }
    }


