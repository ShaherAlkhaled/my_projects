using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var fishs = new Fish[]
            {

         
                new Fish()
                {
                Id = 1,
                Name = "Tong 1",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Tongeen_met.jpg",
                MinWeigth=1,
                MaxWeight=1.5M,
                Price = 30,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 2,
                Name = "Tong 2",
                DateOfArrival = DateTime.Now,
                UrlImage="images/tongtwee.jpg",
                MinWeigth=0.75M,
                MaxWeight=0.1M,
                Price = 27,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 3,
                Name = "Tong 3",
                DateOfArrival = DateTime.Now,
                UrlImage="images/tong_3.jpg",
                MinWeigth=0.5M,
                MaxWeight=0.75M,
                Price = 25,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 4,
                Name = "Tong 4",
                DateOfArrival = DateTime.Now,
                UrlImage="images/tong4.jpg",
                MinWeigth=0.4M,
                MaxWeight=0.5M,
                Price = 33,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 5,
                Name = "Tong 5",
                DateOfArrival = DateTime.Now,
                UrlImage="images/tong5.jpg",
                MinWeigth=0.25M,
                MaxWeight=0.4M,
                Price = 22,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 6,
                Name = "Tong 6",
                DateOfArrival = DateTime.Now,
                UrlImage="images/tong6.png",
                MinWeigth=0.15M,
                MaxWeight=0.25M,
                Price = 19,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 7,
                Name = "Tong 7",
                DateOfArrival = DateTime.Now,
                UrlImage="images/tong7.jpg",
                MinWeigth=0.1M,
                MaxWeight=0.15M,
                Price = 15,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 8,
                Name = "Zalm Heel",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Zalm_heel.jpg",
                MinWeigth=4,
                MaxWeight=5,
                Price = 12,
                CategoryId=4,
                OriginCountryId=5,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 9,
                Name = "Zalm Filet M/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/zalm_filet_met.jpg",
                MinWeigth=1,
                MaxWeight=1.7M,
                Price = 17,
                CategoryId=8,
                OriginCountryId=5,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 10,
                Name = "Zalm Filet Z/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/zalm_filet_zonder.jpg",
                MinWeigth=0.7M,
                MaxWeight=1.7M,
                Price = 25,
                CategoryId=8,
                OriginCountryId=5,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 11,
                Name = "Zalm Portjes M/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/zalm_Por.jpg",
                MinWeigth=0.1M,
                MaxWeight=0.25M,
                Price = 29,
                CategoryId=8,
                OriginCountryId=5,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 12,
                Name = "Zalm Portjes Z/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/zalm_Por_zonder.jpg",
                MinWeigth=0.1M,
                MaxWeight=0.25M,
                Price = 31,
                CategoryId=8,
                OriginCountryId=5,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 13,
                Name = "Kabeljauw Heel",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Kabeljauw.jpg",
                MinWeigth=1M,
                MaxWeight=6M,
                Price = 8,
                CategoryId=4,
                OriginCountryId=2,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 14,
                Name = "Kabeljauw Filet M/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/kabeljauw_filet_met.jpg",
                MinWeigth=0.2M,
                MaxWeight=3.5M,
                Price = 14,
                CategoryId=8,
                OriginCountryId=2,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 15,
                Name = "Kabeljauw Filet Z/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/kabeljauw_filet_zonder.jpg",
                MinWeigth=0.2M,
                MaxWeight=2.7M,
                Price = 18,
                CategoryId=8,
                OriginCountryId=2,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 16,
                Name = "Kabeljauw Portjes M/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/kabeljauw_Por.jpg",
                MinWeigth=0.1M,
                MaxWeight=0.25M,
                Price = 21,
                CategoryId=8,
                OriginCountryId=2,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 17,
                Name = "Kool vis Heel",
                DateOfArrival = DateTime.Now,
                UrlImage="images/koolvis.jpg",
                MinWeigth=1M,
                MaxWeight=13M,
                Price = 6,
                CategoryId=4,
                OriginCountryId=4,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },

               new Fish()
                {
                Id = 18,
                Name = "Kool Filet M/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/koolvis_fileren.jpg",
                MinWeigth=0.5M,
                MaxWeight=0.25M,
                Price = 11,
                CategoryId=8,
                OriginCountryId=4,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 19,
                Name = "vlaswijting Heel",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Pollak_vlaswijting-31.jpg",
                MinWeigth=0.5M,
                MaxWeight=2,
                Price = 12,
                CategoryId=4,
                OriginCountryId=4,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 20,
                Name = "Zeebaars Gekweekt Heel",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Zeebaars.jpg",
                MinWeigth=0.2M,
                MaxWeight=1,
                Price = 8,
                CategoryId=9,
                OriginCountryId=3,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 21,
                Name = "Zeebaars Gewilde",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Gewilde_Zeebaars.png",
                MinWeigth=0.8M,
                MaxWeight=2,
                Price = 14,
                CategoryId=10,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 22,
                Name = "Zalm gewilde Heel",
                DateOfArrival = DateTime.Now,
                UrlImage="images/zalm_gewilde.jpg",
                MinWeigth=1,
                MaxWeight=7,
                Price = 14,
                CategoryId=10,
                OriginCountryId=9,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 23,
                Name = "Dorade Royal",
                DateOfArrival = DateTime.Now,
                UrlImage="images/dorade.png",
                MinWeigth=0.2M,
                MaxWeight=1,
                Price = 8,
                CategoryId=9,
                OriginCountryId=3,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },

               new Fish()
                {
                Id = 24,
                Name = "Kreeft 4/5",
                DateOfArrival = DateTime.Now,
                UrlImage="images/canadese_kreeft_4_5.jpg",
                MinWeigth=0.4M,
                MaxWeight=0.5M,
                Price = 32,
                CategoryId=11,
                OriginCountryId=9,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 25,
                Name = "Kreeft 5/6",
                DateOfArrival = DateTime.Now,
                UrlImage="images/canadese-kreeft_5_6.jpg",
                MinWeigth=0.5M,
                MaxWeight=0.6M,
                Price = 35,
                CategoryId=11,
                OriginCountryId=9,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
               new Fish()
                {
                Id = 26,
                Name = "Kreeft 7/8",
                DateOfArrival = DateTime.Now,
                UrlImage="images/kreeft7_8.jpg",
                MinWeigth=0.7M,
                MaxWeight=0.8M,
                Price = 39,
                CategoryId=11,
                OriginCountryId=9,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },

                new Fish()
                {
                Id = 27,
                Name = "Kreeft 1+",
                DateOfArrival = DateTime.Now,
                UrlImage="images/kreeftPlus.jpg",
                MinWeigth=1,
                MaxWeight=1.4M,
                Price = 42,
                CategoryId=11,
                OriginCountryId=9,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },

                new Fish()
                {
                Id = 28,
                Name = "Griet Heel",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Griet_heel_2.jpg",
                MinWeigth=0.5M,
                MaxWeight=2,
                Price = 19,
                CategoryId=3,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },

                new Fish()
                {
                Id = 29,
                Name = "Wit Heilbot Filet M/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Heilbot_wit_filet.jpg",
                MinWeigth=0.5M,
                MaxWeight=10,
                Price = 25,
                CategoryId=8,
                OriginCountryId=7,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 30,
                Name = "Zwart Heilbot Filet Z/V",
                DateOfArrival = DateTime.Now,
                UrlImage="images/heilbotfilet_zwart_Por.jpg",
                MinWeigth=0.5M,
                MaxWeight=10,
                Price = 15,
                CategoryId=8,
                OriginCountryId=7,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 31,
                Name = "Mosselen Jumbo 1kg",
                DateOfArrival = DateTime.Now,
                UrlImage="images/jumbo_1kg.jpg",
                MinWeigth=0.1M,
                MaxWeight=0.25M,
                Price = 6,
                CategoryId=5,
                OriginCountryId=2,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 32,
                Name = "Mosselen Jumbo 5kg",
                DateOfArrival = DateTime.Now,
                UrlImage="images/jumbo_5.png",
                MinWeigth=0.1M,
                MaxWeight=0.25M,
                Price = 6,
                CategoryId=5,
                OriginCountryId=2,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },

                new Fish()
                {
                Id = 33,
                Name = "Mosselen Jumbo 10kg",
                DateOfArrival = DateTime.Now,
                UrlImage="images/jumbo-mosselen_15.jpg",
                MinWeigth=0.1M,
                MaxWeight=0.25M,
                Price = 6,
                CategoryId=5,
                OriginCountryId=2,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 34,
                Name = "Zwarte-heilbot",
                DateOfArrival = DateTime.Now,
                UrlImage="images/Zwarte-heilbot.png",
                MinWeigth=0.5M,
                MaxWeight=10M,
                Price = 6,
                CategoryId=10,
                OriginCountryId=5,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 35,
                Name = "Zeepaling",
                DateOfArrival = DateTime.Now,
                UrlImage="images/zeepaling_b.jpg",
                MinWeigth=0.2M,
                MaxWeight=2M,
                Price = 35,
                CategoryId=12,
                OriginCountryId=1,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
                new Fish()
                {
                Id = 36,
                Name = "witte_heilbot",
                DateOfArrival = DateTime.Now,
                UrlImage="images/witte_heilbot.jpg",
                MinWeigth=0.2M,
                MaxWeight=125M,
                Price = 35,
                CategoryId=1,
                OriginCountryId=4,
                CreatedOn = DateTime.UtcNow,
                LastEditedOn = DateTime.UtcNow,
                },
   
            };
            var categories = new Category[]
                {
               new Category()
                {
                    Id=1,
                    Name="Verse vis",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
               new Category()
                {
                    Id=2,
                    Name="Diepvries",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },


                new Category()
                {
                    Id=3,
                    Name="Platvis",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=4,
                    Name="Rondvis",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=5,
                    Name="Mosselen",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=6,
                    Name="Schaal & Weekdieren",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=7,
                    Name="Gerookte & gemarineerde vis",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=8,
                    Name="Fileren Vis",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=9,
                    Name="Gekweekte vis",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=10,
                    Name="Wilde vis",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=11,
                    Name="Kreeft",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },
                new Category()
                {
                    Id=12,
                    Name="Diverse",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,

                },

            };
            var originCountries = new OriginCountry[]
            {
                new OriginCountry()
                {
                   Id = 1,
                   Name="België",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id =2 ,
                   Name="Nederland",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 3,
                   Name="Turkije",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 4,
                   Name="Denemarken",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 5,
                   Name="Noorwegen",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 6,
                   Name="Frankrijk",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 7,
                   Name="Zweden",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 8,
                   Name="China",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 9,
                   Name="Canada",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new OriginCountry()
                {
                   Id = 10,
                   Name="Filipijnen",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },

            };
            var processings = new FishProcessing[]
            {
                new FishProcessing()
                {
                    Id=1,
                    Name ="Fileren",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=2,
                    Name ="Gutten",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=3,
                    Name ="OntSchubben",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=4,
                    Name ="Kuisen",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow,

                },
                new FishProcessing()
                {
                    Id=5,
                    Name ="Haas",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=6,
                    Name ="ZonderVel",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=7,
                    Name ="Graatloos",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=8,
                    Name ="Portjes-Snijden",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=9,
                    Name ="Mappen",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=10,
                    Name ="Moten-snijden",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
                new FishProcessing()
                {
                    Id=11,
                    Name ="Koken",
                   CreatedOn = DateTime.UtcNow,
                   LastEditedOn = DateTime.UtcNow,
                },
            };

            var fishProcessing = new[]
            {
                //1
                new {FishsId=1L,FishProssingsId=1L},
                new {FishsId=1L,FishProssingsId=4L},
                new {FishsId=1L,FishProssingsId=6L},
                new {FishsId=1L,FishProssingsId=9L},

                //2
                new {FishsId=2L,FishProssingsId=1L},
                new {FishsId=2L,FishProssingsId=4L},
                new {FishsId=2L,FishProssingsId=6L},
                new {FishsId=2L,FishProssingsId=9L},

                //3
                new {FishsId=3L,FishProssingsId=1L},
                new {FishsId=3L,FishProssingsId=4L},
                new {FishsId=3L,FishProssingsId=6L},
                new {FishsId=3L,FishProssingsId=9L},

                //4
                new {FishsId=4L,FishProssingsId=1L},
                new {FishsId=4L,FishProssingsId=4L},
                new {FishsId=4L,FishProssingsId=6L},
                new {FishsId=4L,FishProssingsId=9L},

                //5
                new {FishsId=5L,FishProssingsId=1L},
                new {FishsId=5L,FishProssingsId=4L},
                new {FishsId=5L,FishProssingsId=6L},
                new {FishsId=5L,FishProssingsId=9L},

                //6
                new {FishsId=6L,FishProssingsId=1L},
                new {FishsId=6L,FishProssingsId=4L},
                new {FishsId=6L,FishProssingsId=6L},
                new {FishsId=6L,FishProssingsId=9L},

                //7
                new {FishsId=7L,FishProssingsId=1L},
                new {FishsId=7L,FishProssingsId=4L},
                new {FishsId=7L,FishProssingsId=6L},
                new {FishsId=7L,FishProssingsId=9L},

                //8
                new {FishsId=8L,FishProssingsId=1L},
                new {FishsId=8L,FishProssingsId=2L},
                new {FishsId=8L,FishProssingsId=3L},
                new {FishsId=8L,FishProssingsId=5L},
                new {FishsId=8L,FishProssingsId=6L},
                new {FishsId=8L,FishProssingsId=7L},
                new {FishsId=8L,FishProssingsId=8L},
                new {FishsId=8L,FishProssingsId=9L},
                new {FishsId=8L,FishProssingsId=10L},

                //9
                new {FishsId=9L,FishProssingsId=3L},
                new {FishsId=9L,FishProssingsId=5L},
                new {FishsId=9L,FishProssingsId=6L},
                new {FishsId=9L,FishProssingsId=7L},
                new {FishsId=9L,FishProssingsId=8L},
                new {FishsId=9L,FishProssingsId=9L},

                //10
                new {FishsId=10L,FishProssingsId=5L},
                new {FishsId=10L,FishProssingsId=7L},
                new {FishsId=10L,FishProssingsId=8L},
                new {FishsId=10L,FishProssingsId=9L},

                //11
                new {FishsId=11L,FishProssingsId=6L},
                new {FishsId=11L,FishProssingsId=9L},
                //12
                new {FishsId=12L,FishProssingsId=6L},
                //13
                new {FishsId=13L,FishProssingsId=1L},
                new {FishsId=13L,FishProssingsId=2L},
                new {FishsId=13L,FishProssingsId=5L},
                new {FishsId=13L,FishProssingsId=6L},
                new {FishsId=13L,FishProssingsId=7L},
                new {FishsId=13L,FishProssingsId=8L},
                new {FishsId=13L,FishProssingsId=9L},
                new {FishsId=13L,FishProssingsId=10L},

                //14
                new {FishsId=14L,FishProssingsId=5L},
                new {FishsId=14L,FishProssingsId=6L},
                new {FishsId=14L,FishProssingsId=7L},
                new {FishsId=14L,FishProssingsId=8L},
                new {FishsId=14L,FishProssingsId=9L},

                //15
                new {FishsId=15L,FishProssingsId=5L},
                new {FishsId=15L,FishProssingsId=7L},
                new {FishsId=15L,FishProssingsId=8L},
                new {FishsId=15L,FishProssingsId=9L},

                //16
                new {FishsId=16L,FishProssingsId=6L},
                new {FishsId=16L,FishProssingsId=9L},
                //17
                new {FishsId=17L,FishProssingsId=3L},
                new {FishsId=17L,FishProssingsId=5L},
                new {FishsId=17L,FishProssingsId=6L},
                new {FishsId=17L,FishProssingsId=7L},
                new {FishsId=17L,FishProssingsId=8L},
                new {FishsId=17L,FishProssingsId=9L},
                //18
                new {FishsId=18L,FishProssingsId=5L},
                new {FishsId=18L,FishProssingsId=7L},
                new {FishsId=18L,FishProssingsId=8L},
                new {FishsId=18L,FishProssingsId=9L},
                //19
                new {FishsId=19L,FishProssingsId=3L},
                new {FishsId=19L,FishProssingsId=5L},
                new {FishsId=19L,FishProssingsId=6L},
                new {FishsId=19L,FishProssingsId=7L},
                new {FishsId=19L,FishProssingsId=8L},
                new {FishsId=19L,FishProssingsId=9L},

                //20
                new {FishsId=20L,FishProssingsId=1L},
                new {FishsId=20L,FishProssingsId=2L},
                new {FishsId=20L,FishProssingsId=3L},
                new {FishsId=20L,FishProssingsId=4L},
                new {FishsId=20L,FishProssingsId=6L},
                new {FishsId=20L,FishProssingsId=7L},
                //21
                new {FishsId=21L,FishProssingsId=1L},
                new {FishsId=21L,FishProssingsId=2L},
                new {FishsId=21L,FishProssingsId=3L},
                new {FishsId=21L,FishProssingsId=4L},
                new {FishsId=21L,FishProssingsId=6L},
                new {FishsId=21L,FishProssingsId=7L},
                //22
                new {FishsId=22L,FishProssingsId=1L},
                new {FishsId=22L,FishProssingsId=2L},
                new {FishsId=22L,FishProssingsId=3L},
                new {FishsId=22L,FishProssingsId=4L},
                new {FishsId=22L,FishProssingsId=6L},
                new {FishsId=22L,FishProssingsId=7L},
                //23
                new {FishsId=23L,FishProssingsId=1L},
                new {FishsId=23L,FishProssingsId=2L},
                new {FishsId=23L,FishProssingsId=3L},
                new {FishsId=23L,FishProssingsId=4L},
                new {FishsId=23L,FishProssingsId=6L},
                new {FishsId=23L,FishProssingsId=7L},
                //24
                new {FishsId=24L,FishProssingsId=11L},
                //25
                new {FishsId=25L,FishProssingsId=11L},
                //26
                new {FishsId=26L,FishProssingsId=11L},
                //27
                new {FishsId=27L,FishProssingsId=11L},
                //28
                new {FishsId=28L,FishProssingsId=1L},
                new {FishsId=28L,FishProssingsId=4L},
                new {FishsId=28L,FishProssingsId=6L},
                new {FishsId=28L,FishProssingsId=9L},
                //29
                new {FishsId=29L,FishProssingsId=6L},
                new {FishsId=29L,FishProssingsId=8L},
                new {FishsId=29L,FishProssingsId=9L},
                //30
                new {FishsId=30L,FishProssingsId=8L},
                new {FishsId=30L,FishProssingsId=9L},
                //31
                new {FishsId=31L,FishProssingsId=11L},
                //32
                new {FishsId=32L,FishProssingsId=11L},
            };

            var usersToSeed = new List<ApplicationUser>();
            // Adim
            const string AdminRoleId = "00000000-0000-0000-0000-000000000001";
            const string AdminRoleName = "Admin";
            const string UserRoleId = "00000000-0000-0000-0000-000000000002";
            const string UserRoleName = "User";
            const string AdminUserId = "00000000-0000-0000-0000-000000000001";
            const string AdminUserName = "ImiAdmin";
            const string AdminEmail = "admin@imi.be";
            const string password = "Test123?";
            usersToSeed.Add(new ApplicationUser
            {
                Id = AdminUserId,
                UserName = AdminUserName,
                NormalizedUserName = AdminUserName.ToUpper(),
                Email = AdminEmail,
                NormalizedEmail = AdminEmail.ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA",
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58",
                BirthDate = new DateTime(2000, 01, 01),
                LockoutEnabled = true,

            });


            // ImiUser
            const string ImiUserId = "00000000-0000-0000-0000-000000000002";
            const string ImiUserName = "ImiUser";
            const string ImiUserEmail = "user@imi.be";
            usersToSeed.Add(new ApplicationUser
            {
                Id = ImiUserId,
                UserName = ImiUserName,
                NormalizedUserName = ImiUserName.ToUpper(),
                Email = ImiUserEmail,
                NormalizedEmail = ImiUserEmail.ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJ7895CSW2GWPRADBXEZINA",
                ConcurrencyStamp = "c8554266-b897-4519-9aeb-a9283053fc58",
                BirthDate = new DateTime(1980, 01, 01),
                HasApprovedTermsAndConditions = true
            });

            // ImiRefuser
            const string ImiRefuserId = "00000000-0000-0000-0000-000000000003";
            const string ImiRefuserName = "ImiRefuser";
            const string ImiRefuserEmail = "refuser@imi.be";
            usersToSeed.Add(new ApplicationUser
            {
                Id = ImiRefuserId,
                UserName = ImiRefuserName,
                NormalizedUserName = ImiRefuserName.ToUpper(),
                Email = ImiRefuserEmail,
                NormalizedEmail = ImiRefuserEmail.ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJ7895CSW2GWPRADBXEZINA",
                ConcurrencyStamp = "c8554266-b897-4519-9aeb-a9283053fc58",
                BirthDate = new DateTime(1990, 01, 01),
                HasApprovedTermsAndConditions = false
            });

            IPasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();

            foreach (var user in usersToSeed)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, password);
            }
            modelBuilder.Entity<IdentityRole>().HasData
                (new IdentityRole
                {
                    Id = AdminRoleId,
                    Name = AdminRoleName,
                    NormalizedName = AdminRoleName.ToUpper(),
                    ConcurrencyStamp = "1D6B7B4D-E325-498F-8A57-3637783370E6",
                });
            modelBuilder.Entity<IdentityRole>().HasData
              (new IdentityRole
              {
                  Id = UserRoleId,
                  Name = UserRoleName,
                  NormalizedName = UserRoleName.ToUpper(),
                  ConcurrencyStamp = "c8554266-b897-4519-9aeb-a9283053fc58",
              });
            modelBuilder.Entity<ApplicationUser>().HasData(usersToSeed);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
             new IdentityUserRole<string>
             {
                 RoleId = AdminRoleId,
                 UserId = AdminUserId
             },
            new IdentityUserRole<string>
            {
                RoleId = UserRoleId,
                UserId = ImiUserId
            },
             new IdentityUserRole<string>
             {
                 RoleId = UserRoleId,
                 UserId = ImiRefuserId
             });

            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
                            new IdentityUserClaim<string>
                            {
                                Id = 1,
                                UserId = "00000000-0000-0000-0000-000000000002",
                                ClaimType = "HasApprovedTermsAndConditions",
                                ClaimValue = true.ToString(),
                            },
                             new IdentityUserClaim<string>
                             {
                                 Id = 2,
                                 UserId = "00000000-0000-0000-0000-000000000003",
                                 ClaimType = "HasApprovedTermsAndConditions",
                                 ClaimValue = false.ToString(),
                             });


            modelBuilder.Entity<Fish>()
                 .HasData(fishs);
            modelBuilder.Entity<Category>()
                .HasData(categories);
            modelBuilder.Entity<FishProcessing>()
                .HasData(processings);
            modelBuilder.Entity<OriginCountry>()
                .HasData(originCountries);
            modelBuilder.Entity($"{nameof(Fish)}{nameof(FishProcessing)}")
                .HasData(fishProcessing);
        }



    }
}
