using Microsoft.EntityFrameworkCore;
using PE1.Webshop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Data.Seeding
{
    public class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var products = new Product[]
            {
                new Product
                {
                    Id=1,
                    Name="Gaming Laptop",
                    Brand="Msi",
                    Model="GE63",
                    Price=1549,
                    Rating=5,
                    ImageFileName="Gaming-laptop-GE63.gif" ,
                    CatergoryId=1
                },
                // 2 
                new Product{
                    Id=2,
                    Name="Gaming Laptop",
                    Brand="Asus",
                    Model="GL504GM",
                    Price=1389,
                    Rating=4,
                    ImageFileName="Gaming-laptop-GL504GM.jpg" ,
                    CatergoryId=1

                },
                // 3
                new Product
                {
                    Id=3,
                    Name="Gaming Laptop",
                    Brand="Msi",
                    Model="GF63",
                    Price=995,
                    Rating=4,
                    ImageFileName="MSI-Gaming-Laptop-GF63.png" ,
                    CatergoryId=1
                },
                //4
                new Product
                {
                    Id=4,
                    Name="Gaming Laptop",
                    Brand="HP",
                    Model="OMEN 15-ek1021nb Intel Core i7-10870H",
                    Price=2199,
                    Rating=5,
                    ImageFileName="HP-Gaming-Laptop-OMEN-15-ek1021nb-Intel-Core-i7.png" ,
                    CatergoryId=1
                },
                      //5
                new Product
                {
                    Id=5,
                    Name="Laptop",
                    Brand="HP",
                    Model="15-dw1050nb Intel Pentium Gold 6405U (2B0C1EA)",
                    Price=499,
                    Rating=2,
                    ImageFileName="HP-Laptop-15-dw1050nb-Intel-Pentium.png" ,
                    CatergoryId=1
                },
                 //6
                new Product
                {
                    Id=6,
                    Name="Gaming Laptop",
                    Brand="Lenovo",
                    Model="Yoga Slim 9 14ITL5 Intel Core i7-1065G7",
                    Price=1999,
                    Rating=8,
                    ImageFileName="LENOVO-Laptop-Yoga-Slim-9-14ITL5-Intel-Core-i7.png" ,
                    CatergoryId=1
                },
                  //7
                new Product
                {
                    Id=7,
                    Name="Laptop IdeaPad 3",
                    Brand="Lenvovo",
                    Model="15ALC6 AMD Ryzen 5 5500U (82KU00NLMB)",
                    Price=599,
                    Rating=4,
                    ImageFileName="LENOVO-Laptop-IdeaPad-3.png" ,
                    CatergoryId=1
                },
                //8
                new Product
                {
                    Id=8,
                    Name="Galaxy",
                    Brand="Samsung",
                    Model="S20",
                    Price=600,
                    ImageFileName="S20.jpg" ,
                    Rating=4,
                    CatergoryId=2
                },
                      //9
                new Product
                {
                    Id=9,
                    Name="Galaxy",
                    Brand="Samsung",
                    Model="S21",
                    Price=700,
                    Rating=5,
                    ImageFileName="S21.jpg" ,
                    CatergoryId=2
                },
                //10
                new Product
                {
                    Id=10,
                    Name="Galaxy",
                    Brand="Samsung",
                    Model="S21 Ultra",
                    Price=1099,
                    Rating=5,
                    ImageFileName="S21-Ultra.jpg" ,
                    CatergoryId=2
                },
                  //11
                new Product
                {
                    Id=11,
                    Name="iPhone",
                    Brand="APPLE",
                    Model="13 Pro Max 5G 1 TB Silver",
                    Price=1893,
                    Rating=5,
                    ImageFileName="APPLE-iPhone-13-Pro-Max-5G-1-TB-Silver.png" ,
                    CatergoryId=2
                },
                    //12
                new Product
                {
                    Id=12,
                    Name="iPhone",
                    Brand="APPLE",
                    Model="13 Pro 5G 1 TB Graphite",
                    Price=1795,
                    Rating=5,
                    ImageFileName="APPLE-iPhone-13-Pro-5G-1-TB.png",
                    CatergoryId=2
                },
                  //13
                new Product
                {
                    Id=13,
                    Name="iPhone",
                    Brand="APPLE",
                    Model="SE 64 GB 2nd Gen. Zwart (MX9R2ZD/A)",
                    Price=439,
                    Rating=5,
                    ImageFileName="APPLE-iPhone-SE-64-GB.png" ,
                    CatergoryId=2
                },


                //14
                new Product
                {
                    Id=14,
                    Name="TV LED",
                    Brand="Samsung",
                    Model="UE40T5300AWXXN",
                    Price=399,
                    Rating=3,
                    ImageFileName="UE40T5300AWXXN.jpg" ,
                    CatergoryId=3
                },
                //15
                new Product
                {
                    Id=15,
                    Name="TV NEO QLED 4K 65 INCH",
                    Brand="Samsung",
                    Model="QE65QN95AATXXN",
                    Price=1389,
                    ImageFileName="QE65QN95AATXXN.jpg" ,
                    Rating=5,
                    CatergoryId=3
                },
                //16
                new Product
                {
                    Id=16,
                    Name="Crystal UHD",
                    Brand="Samsung",
                    Model="43TU7020",
                    Price=439,
                    ImageFileName="43TU7020.png" ,
                    Rating=2,
                    CatergoryId=3
                },
                //17
                new Product
                {
                    Id=17,
                    Name="PlayStation 3",
                    Brand="Sony",
                    Model="Slim-320GB",
                    Price=109,
                    ImageFileName="playstation3.jpg" ,
                    Rating=1,
                    CatergoryId=4
                },
                //18
                new Product
                {
                    Id=18,
                    Name="PlayStation 4",
                    Brand="Sony",
                    Model="PRO-1Tb",
                    Price=250,
                    ImageFileName="Palystation4.png" ,
                    Rating=3,
                    CatergoryId=4
                },
                //19
                new Product
                {
                    Id=19,
                    Name="PlayStation 5",
                    Brand="Sony",
                    Model="Digital Edition",
                    Price=399,
                    Rating=5,
                    ImageFileName="PlayStation5.png" ,
                    CatergoryId=4
                },
                //20
                new Product
                {
                    Id=20,
                    Name="Koelkast",
                    Brand="BOSCH",
                    Model="vriescombinatie-E-(KGN39VLEA)",
                    Price=599,
                    ImageFileName="BOSCH-Koel.png" ,
                    Rating=3,
                    CatergoryId=5
                },
                //21
                new Product
                {
                    Id=21,
                    Name="Amerikaanse koelkast",
                    Brand="LG",
                    Model="E-(GSXV90MCDE)",
                    Price=2599,
                    Rating=5,
                    ImageFileName="LG-Amerikaanse-koeling.png" ,
                    CatergoryId=5
                },
                //22
                new Product
                {
                    Id=22,
                    Name="Amerikaanse koelkast",
                    Brand="Samsung",
                    Model="RS68A8831B1 SpaceMax™",
                    Price=1298,
                    ImageFileName="KoelingSamsung.jpg" ,
                    Rating=5,
                    CatergoryId=5
                },
                //23
                new Product
                {
                    Id=23,
                    Name="Wasmachine",
                    Brand="BOSCH",
                    Model="voorlader C (WAX32MM0FG)",
                    Price=989,
                    ImageFileName="BOSCH-Wasmachine.png" ,
                    Rating=4,
                    CatergoryId=5
                },
                //24
                new Product
                {
                    Id=24,
                    Name="Wasmachine ",
                    Brand="Samsung",
                    Model="voorlader A (WW90T684ALE/S2)",
                    Price=749,
                    ImageFileName="SAMSUNG-Wasmachine.png" ,
                    Rating=4,
                    CatergoryId=5
                },
                //25
                new Product
                {
                    Id=25,
                    Name="Wasmachine",
                    Brand="LG",
                    Model="voorlader E (LC1R7N2)",
                    Price=998,
                    ImageFileName="LG-Wasmachine.png" ,
                    Rating=5,
                    CatergoryId=5
                },
                //26
                new Product
                {
                    Id=26,
                    Name="Wasmachine",
                    Brand="WHIRLPOOL",
                    Model="voorlader D (FFSBE 7438 WE F)",
                    Price=299,
                    ImageFileName="WHIRLPOOL-Wasmachine.png" ,
                    Rating=1,
                    CatergoryId=5
                },
                //27
                new Product
                {
                    Id=27,
                    Name="Wasmachine",
                    Brand="AEG",
                    Model="voorlader ProSteam C (L7FE86PROS)",
                    Price=699,
                    Rating=5,
                    ImageFileName="AEG-Wasmachine.png" ,
                    CatergoryId=5
                },

            };


            var categories = new Category[]
            {
                new Category { Id=1,Name="Computer"},
                new Category { Id=2,Name="SmartPhone"},
                new Category { Id=3,Name="TV"},
                new Category { Id=4,Name="Games"},
                new Category { Id=5,Name="Large Electric"},

            };

            var properties = new Property[]
            {
               new Property{Id= 1,Name="Desktop"},
               new Property{Id= 2,Name="Student"},
               new Property{Id= 3,Name="Budget"},
               new Property{Id= 4,Name="Speed"},
               new Property{Id= 5,Name="Family"},
               new Property{Id= 6,Name="Gaming"},
               new Property{Id= 7,Name="Graphics card"},
               new Property{Id= 8,Name="Luxury"},
               new Property{Id= 9,Name="kitchen"},
               new Property{Id= 10,Name="Wash"},
               new Property{Id= 11,Name="Cooling"},

            };

            var productProperty = new[]
            {
                new{ProductId=1L,PropertyId=1L},
                new{ProductId=1L,PropertyId=2L},
                new{ProductId=1L,PropertyId=3L},
                new{ProductId=1L,PropertyId=4L},
                new{ProductId=1L,PropertyId=5L},
                new{ProductId=1L,PropertyId=6L},
                new{ProductId=1L,PropertyId=7L},
                new{ProductId=1L,PropertyId=8L},
                //
                new{ProductId=2L,PropertyId=1L},
                new{ProductId=2L,PropertyId=2L},
                new{ProductId=2L,PropertyId=3L},
                new{ProductId=2L,PropertyId=4L},
                new{ProductId=2L,PropertyId=5L},
                new{ProductId=2L,PropertyId=6L},
                new{ProductId=2L,PropertyId=7L},
                new{ProductId=2L,PropertyId=8L},
                //
                new{ProductId=3L,PropertyId=1L},
                new{ProductId=3L,PropertyId=2L},
                new{ProductId=3L,PropertyId=3L},
                new{ProductId=3L,PropertyId=4L},
                new{ProductId=3L,PropertyId=5L},
                new{ProductId=3L,PropertyId=6L},
                new{ProductId=3L,PropertyId=7L},
                //
                new{ProductId=4L,PropertyId=1L},
                new{ProductId=4L,PropertyId=2L},
                new{ProductId=4L,PropertyId=3L},
                new{ProductId=4L,PropertyId=4L},
                new{ProductId=4L,PropertyId=5L},
                new{ProductId=4L,PropertyId=6L},
                new{ProductId=4L,PropertyId=7L},
                new{ProductId=4L,PropertyId=8L},
                //
                new{ProductId=5L,PropertyId=1L},
                new{ProductId=5L,PropertyId=2L},
                new{ProductId=5L,PropertyId=4L},
                new{ProductId=5L,PropertyId=5L},
                new{ProductId=5L,PropertyId=7L},
                //
                new{ProductId=6L,PropertyId=1L},
                new{ProductId=6L,PropertyId=2L},
                new{ProductId=6L,PropertyId=3L},
                new{ProductId=6L,PropertyId=4L},
                new{ProductId=6L,PropertyId=5L},
                new{ProductId=6L,PropertyId=6L},
                new{ProductId=6L,PropertyId=7L},
                new{ProductId=6L,PropertyId=8L},
                //
                new{ProductId=7L,PropertyId=1L},
                new{ProductId=7L,PropertyId=2L},
                new{ProductId=7L,PropertyId=4L},
                new{ProductId=7L,PropertyId=5L},
                new{ProductId=7L,PropertyId=7L},
                //
                new{ProductId=8L,PropertyId=3L},
                new{ProductId=8L,PropertyId=4L},
                new{ProductId=8L,PropertyId=6L},
                //
                new{ProductId=9L,PropertyId=3L},
                new{ProductId=9L,PropertyId=4L},
                new{ProductId=9L,PropertyId=6L},
                //
                new{ProductId=10L,PropertyId=3L},
                new{ProductId=10L,PropertyId=4L},
                new{ProductId=10L,PropertyId=6L},
                new{ProductId=10L,PropertyId=8L},
                //
                new{ProductId=11L,PropertyId=3L},
                new{ProductId=11L,PropertyId=4L},
                new{ProductId=11L,PropertyId=6L},
                new{ProductId=11L,PropertyId=8L},
                //
                new{ProductId=12L,PropertyId=3L},
                new{ProductId=12L,PropertyId=4L},
                new{ProductId=12L,PropertyId=6L},
                new{ProductId=12L,PropertyId=8L},
                //
                new{ProductId=13L,PropertyId=3L},
                new{ProductId=13L,PropertyId=4L},
                new{ProductId=13L,PropertyId=6L},
                //
                new{ProductId=14L,PropertyId=1L},
                new{ProductId=14L,PropertyId=3L},
                new{ProductId=14L,PropertyId=5L},
                new{ProductId=14L,PropertyId=6L},
                new{ProductId=14L,PropertyId=8L},
                //
                new{ProductId=15L,PropertyId=1L},
                new{ProductId=15L,PropertyId=3L},
                new{ProductId=15L,PropertyId=5L},
                new{ProductId=15L,PropertyId=6L},
                new{ProductId=15L,PropertyId=8L},
                //
                new{ProductId=16L,PropertyId=1L},
                new{ProductId=16L,PropertyId=3L},
                new{ProductId=16L,PropertyId=5L},
                new{ProductId=16L,PropertyId=6L},
                //
                new{ProductId=17L,PropertyId=4L},
                new{ProductId=17L,PropertyId=5L},
                new{ProductId=17L,PropertyId=6L},
                //
                new{ProductId=18L,PropertyId=4L},
                new{ProductId=18L,PropertyId=5L},
                new{ProductId=18L,PropertyId=6L},
                //
                new{ProductId=19L,PropertyId=4L},
                new{ProductId=19L,PropertyId=5L},
                new{ProductId=19L,PropertyId=6L},
                new{ProductId=19L,PropertyId=8L},
                //
                new{ProductId=20L,PropertyId=3L},
                new{ProductId=20L,PropertyId=5L},
                new{ProductId=20L,PropertyId=9L},
                new{ProductId=20L,PropertyId=11L},
                //
                new{ProductId=21L,PropertyId=3L},
                new{ProductId=21L,PropertyId=5L},
                new{ProductId=21L,PropertyId=9L},
                new{ProductId=21L,PropertyId=11L},
                //
                new{ProductId=22L,PropertyId=3L},
                new{ProductId=22L,PropertyId=5L},
                new{ProductId=22L,PropertyId=9L},
                new{ProductId=22L,PropertyId=11L},
                //
                new{ProductId=23L,PropertyId=3L},
                new{ProductId=23L,PropertyId=4L},
                new{ProductId=23L,PropertyId=5L},
                new{ProductId=23L,PropertyId=9L},
                new{ProductId=23L,PropertyId=10L},
                //
                new{ProductId=24L,PropertyId=3L},
                new{ProductId=24L,PropertyId=4L},
                new{ProductId=24L,PropertyId=5L},
                new{ProductId=24L,PropertyId=9L},
                new{ProductId=24L,PropertyId=10L},
                //
                new{ProductId=25L,PropertyId=3L},
                new{ProductId=25L,PropertyId=4L},
                new{ProductId=25L,PropertyId=5L},
                new{ProductId=25L,PropertyId=9L},
                new{ProductId=25L,PropertyId=10L},
                //
                new{ProductId=26L,PropertyId=3L},
                new{ProductId=26L,PropertyId=4L},
                new{ProductId=26L,PropertyId=5L},
                new{ProductId=26L,PropertyId=9L},
                new{ProductId=26L,PropertyId=10L},
                //
                new{ProductId=27L,PropertyId=3L},
                new{ProductId=27L,PropertyId=4L},
                new{ProductId=27L,PropertyId=5L},
                new{ProductId=27L,PropertyId=9L},
                new{ProductId=27L,PropertyId=10L},
            };

            modelBuilder.Entity<Product>()
                .HasData(products);
            modelBuilder.Entity<Category>()
                .HasData(categories);
            modelBuilder.Entity<Property>()
                .HasData(properties);
            //use entity basic method for Coursestudent
            modelBuilder.Entity($"{nameof(Product)}{nameof(Property)}")
                .HasData(productProperty);


        }




    }
}

