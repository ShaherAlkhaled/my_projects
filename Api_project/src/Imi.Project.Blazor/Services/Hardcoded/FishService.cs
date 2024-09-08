using BlazorInputFile;
using Imi.Project.Blazor.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Hardcoded
{
    public class FishService 
    {
        //private readonly IWebHostEnvironment _webHostEnvironment;

        //public FishService(IWebHostEnvironment webHostEnvironment)
        //{
        //    _webHostEnvironment = webHostEnvironment;
        //}
        //private static List<SelectListItem> categories = new List<SelectListItem>{
        //    new SelectListItem() {Text="PlateFish",Value="1" },
        //    new SelectListItem() { Text = "Rond Fish",Value="2" },
        //    new SelectListItem() {Text="Mosselen",Value="3" },
        //    new SelectListItem() { Text = "Schaal & Weekdieren",Value="4" },
        //    new SelectListItem() {Text="Gerookt vis",Value="5" },
        //    new SelectListItem() { Text = "Diepvries",Value="6" },
        //    new SelectListItem() {Text="Gekweekte vis",Value="7" },
        //    new SelectListItem() { Text = "Verse vis",Value="8" },
        //    new SelectListItem() {Text="Diverse",Value="9" },
        //    new SelectListItem() { Text = "Fileren Vis",Value="10" },
        //    new SelectListItem() { Text = "Kreeft",Value="11" },
        //};

        //private static List<FishProssing> fishProssings = new List<FishProssing>{
        //    new FishProssing() { Id = 1, Name = "Filet",  },
        //    new FishProssing() { Id = 2, Name = "Geheel",  },
        //    new FishProssing() { Id = 3, Name = "OntSchubben",  },
        //    new FishProssing() { Id = 4, Name = "Kuisen",  },
        //    new FishProssing() { Id = 5, Name = "Haas",  },
        //    new FishProssing() { Id = 6, Name = "ZonderVel",},
        //    new FishProssing() { Id = 7, Name = "Graatloos",},
        //    new FishProssing() { Id = 8, Name = "Mappen",},
        //    new FishProssing() { Id = 9, Name = "Portjes-Snijden",},
        //    new FishProssing() { Id = 10, Name = "Gutten",},

        //};

        //private List<FishItem> fishs = new List<FishItem>{
        //    new FishItem()
        //    {
        //        Id = 1,
        //        Name = "Tong 1",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        UrlImage="tong1m_v.png",
        //        MinWeigth=0.75M,
        //        MaxWeight=1,
        //        Price = 30,
        //        CategoryId=1,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //        },
        //    },
        //    new FishItem()
        //    {
        //        Id = 2,
        //        Name = "Tong 2",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        Price= 25,
        //        UrlImage="tong2m_v.jpg",
        //        MinWeigth=0.5M,
        //        MaxWeight=0.75M,
        //        CategoryId=1,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 3,
        //        Name = "Zalm",
        //        OriginCountry = "Denemarken",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth = 1,
        //        MaxWeight = 7,
        //        UrlImage = "zalm.jpg",
        //        Price = 17,
        //        CategoryId=2,
        //        FishProssings=fishProssings,
                
        //        //new List<FishProssing>
        //        //{
        //        //        fishProssings.FirstOrDefault(p=>p.Id==1),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==2),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==3),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==4),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==5),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==6),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==7),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==8),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==9),
        //        //        fishProssings.FirstOrDefault(p=>p.Id==10),
        //        //}
        //    },
        //     new FishItem()
        //     {
        //         Id = 4,
        //         Name = "kabeljauw",
        //        OriginCountry = "België",
        //        Price = 9,
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=0.5M,
        //        MaxWeight=6,
        //        UrlImage= "kabeljauw.jpg",
        //        CategoryId=2,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==4),
        //                fishProssings.FirstOrDefault(p=>p.Id==5),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //        }
        //     },
        //    new FishItem()
        //    {
        //        Id = 5,
        //        Name = "Zalm Fielt",
        //        OriginCountry = "Denemarken",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=.10M,
        //        MaxWeight=1.9M,
        //        UrlImage= "zalmfilet.png",
        //        Price = 18,
        //        CategoryId=10,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==3),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //                fishProssings.FirstOrDefault(p=>p.Id==9),
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 6,
        //        Name = "kabeljauw fielt",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=0.1M,
        //        MaxWeight=5,
        //        UrlImage= "Kabeljauwfilet.jpg",
        //        Price= 14.36M,
        //        CategoryId=10,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==3),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //                fishProssings.FirstOrDefault(p=>p.Id==9),
        //        }
        //    },

        //    new FishItem()
        //    {
        //        Id = 7,
        //        Name = "ZeeWolf - Filet",
        //        OriginCountry = "Denemarken",
        //        DateOfArrival = DateTime.Now,
        //        Price = 13.3M,
        //        MinWeigth = .01M,
        //        MaxWeight=2M,
        //        UrlImage="zeewolf_filet.jpg",
        //        CategoryId=10,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==3),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //                fishProssings.FirstOrDefault(p=>p.Id==9),


        //        }
        //    },
        //    new FishItem()
        //    { 
        //        Id = 8,
        //        Name = "Dorade Royal",
        //        OriginCountry = "Turkije",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=.25M,
        //        MaxWeight=.9M,
        //        UrlImage="Dorade.jpg",
        //        Price= 7.9M,
        //        CategoryId=8,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==3),
        //                fishProssings.FirstOrDefault(p=>p.Id==4),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //                fishProssings.FirstOrDefault(p=>p.Id==10),
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 9,
        //        Name = "Zee Baars",
        //        OriginCountry = "Turkije",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=.25M,
        //        MaxWeight=.9M,
        //        UrlImage="download.jpg",
        //        Price= 7.9M,
        //        CategoryId=8,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==3),
        //                fishProssings.FirstOrDefault(p=>p.Id==4),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //                fishProssings.FirstOrDefault(p=>p.Id==10),
        //        }
        //    },


        //    new FishItem()
        //    {
        //        Id = 10,
        //        Name = "Zeeduviel",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        UrlImage="zeeduivel1.png",
        //        MinWeigth=0.5M,
        //        MaxWeight=5,
        //        Price = 30,
        //        CategoryId=9,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //        },
        //    },
        //    new FishItem()
        //    {
        //        Id = 11,
        //        Name = "Wijting",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        Price= 2,
        //        UrlImage="wijting.jpg",
        //        MinWeigth=0.5M,
        //        MaxWeight=1.5M,
        //        CategoryId=2,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 12,
        //        Name = "Zeewolf",
        //        OriginCountry = "Denemarken",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth = 1,
        //        MaxWeight = 3,
        //        UrlImage = "zeewolf.png",
        //        Price = 8,
        //        CategoryId=2,
        //        FishProssings=fishProssings,
        //    },
        //     new FishItem()
        //     {
        //         Id = 13,
        //         Name = "Zwart Helibot",
        //        OriginCountry = "Zweden",
        //        Price = 20,
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=0.5M,
        //        MaxWeight=10,
        //        UrlImage= "ZwartHelibot.jpg",
        //        CategoryId=2,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==1),
        //                fishProssings.FirstOrDefault(p=>p.Id==2),
        //                fishProssings.FirstOrDefault(p=>p.Id==4),
        //                fishProssings.FirstOrDefault(p=>p.Id==5),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==7),
        //        }
        //     },
        //    new FishItem()
        //    {
        //        Id = 14,
        //        Name = "victoriabaar",
        //        OriginCountry = "Filipijnen",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=.5M,
        //        MaxWeight=2M,
        //        UrlImage= "verse-victoriabaar.png",
        //        Price = 9,
        //        CategoryId=2,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==3),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //                fishProssings.FirstOrDefault(p=>p.Id==9),
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 15,
        //        Name = "VlasWijting",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=0.1M,
        //        MaxWeight=5,
        //        UrlImage= "Pollak_vlaswijting-31.jpg",
        //        Price= 14.36M,
        //        CategoryId=2,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==3),
        //                fishProssings.FirstOrDefault(p=>p.Id==6),
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //                fishProssings.FirstOrDefault(p=>p.Id==9),
        //        }
        //    },

        //    new FishItem()
        //    {
        //        Id = 16,
        //        Name = "Kreeft",
        //        OriginCountry = "Canada",
        //        DateOfArrival = DateTime.Now,
        //        Price = 50M,
        //        MinWeigth = .01M,
        //        MaxWeight=1.2M,
        //        UrlImage="Canadese-kreeft.jpg",
        //        CategoryId=11,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==4),
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 17,
        //        Name = "Frans Mosselen",
        //        OriginCountry = "Frans",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=.05M,
        //        MaxWeight=.2M,
        //        UrlImage="fransMosselen.jpg",
        //        Price= 5.9M,
        //        CategoryId=3,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 18,
        //        Name = "Gerookt Zalm",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=.25M,
        //        MaxWeight=1.9M,
        //        UrlImage="GerooktZalm.jpg",
        //        Price= 25M,
        //        CategoryId=5,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==8),
                        
        //        }
        //    },
        //    new FishItem()
        //    {
        //        Id = 19,
        //        Name = "Gerookt Heilbot",
        //        OriginCountry = "België",
        //        DateOfArrival = DateTime.Now,
        //        MinWeigth=.25M,
        //        MaxWeight=1.9M,
        //        UrlImage="gerookte-heilbot-met-roerei.jpg",
        //        Price= 25M,
        //        CategoryId=5,
        //        FishProssings=new List<FishProssing>
        //        {
        //                fishProssings.FirstOrDefault(p=>p.Id==8),

        //        }
        //    },
        //};

        //public Task<List<FishListItem>> GetList()
        //{
        //    return Task.FromResult(
        //       fishs.Select(x => new FishListItem()
        //       {
        //           Id = x.Id,
        //           Name = x.Name,
        //           Price = x.Price,
        //           UrlImage = x.UrlImage,
        //       }).ToList()
        //   );
        //}
        //public Task Create(FishItem item)
        //{
        //    item.Id = fishs.Count() > 0 ? fishs.Max(x => x.Id) + 1 : 1;

        //    var selectedProperties = item
        //       .Properties
        //       .Where(p => p.IsSelected == true).Select(p => p.Id);

        //    var newFish = new FishItem()
        //    {
        //        Id = item.Id,
        //        Name = item.Name,
        //        Price = item.Price,
        //        UrlImage = item.UrlImage,
        //        MaxWeight = item.MaxWeight,
        //        MinWeigth = item.MinWeigth,
        //        Category = categories
        //                .Where(y => y.Value == item.CategoryId.ToString())
        //                .Select(y => y.Text)
        //                .SingleOrDefault(),
        //        DateOfArrival = item.DateOfArrival,
        //        OriginCountry = item.OriginCountry,
        //        FishProssings =
        //        fishProssings.Where(p => selectedProperties.Contains(p.Id)).ToList(),

        //    };
        //    fishs.Add(newFish);
        //    return Task.CompletedTask;
        //}
        //public Task<FishItem> GetNew()
        //{
        //    var fish = new FishItem();
        //    fish.CategoryList = categories;
        //    fish.CategoryId = Int32.Parse(categories.First().Value);
        //    fish.Properties = fishProssings
        //         .Select(p => new CheckBoxModel()
        //         {
        //             Id = p.Id,
        //             Name = p.Name,

        //         }).ToList();
        //    return Task.FromResult(fish);
        //}
        //public async Task<FishItem> Get(long id)
        //{
        //    var fish = fishs.SingleOrDefault(x => x.Id == id);
        //    fish.CategoryList = categories;
        //    fish.Properties = fishProssings
        //           .Select(p => new CheckBoxModel()
        //           {
        //               Id = p.Id,
        //               Name = p.Name,
        //               IsSelected =
        //             fish.FishProssings.Any(f => f.Id == p.Id),


        //           }).ToList();
        //    return await Task.FromResult(fish);
        //}
        //public Task Update(FishItem item)
        //{
        //    var selectedProperties = item
        //               .Properties
        //               .Where(p => p.IsSelected == true).Select(p => p.Id);
        //    var fish = fishs.SingleOrDefault(x => x.Id == item.Id);
        //    if (fish == null) throw new ArgumentException("Fish not found!");
        //    fish.Name = item.Name;
        //    fish.Price = item.Price;
        //    fish.DateOfArrival = item.DateOfArrival;
        //    fish.CategoryId = item.CategoryId;
        //    fish.FishProssings =
        //         fishProssings.Where(p => selectedProperties.Contains(p.Id)).ToList();
        //    fish.OriginCountry = item.OriginCountry;
        //    fish.UrlImage = item.UrlImage;
        //    return Task.CompletedTask;
        //}
        //public Task Delete(long id)
        //{
        //    var fish = fishs.SingleOrDefault(x => x.Id == id);
        //    if (fish == null) throw new ArgumentException("Fish not found!");
        //    fishs.Remove(fish);
        //    return Task.CompletedTask;
        //}
        //public async Task FileUpload(IFileListEntry fileEntry)
        //{
        //    // This source code https://youtu.be/7OudZqyeHxg

        //    var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileEntry.Name);
        //    var ms = new MemoryStream();
        //    await fileEntry.Data.CopyToAsync(ms);
        //    using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
        //    {

        //        ms.WriteTo(file);

        //    };
        //}
        //public List<FishListItem> ListAll()
        //{
        //    return fishs.Select(f => new FishListItem
        //    {
        //        Id = f.Id,
        //        Name = f.Name,
        //        UrlImage = f.UrlImage,
        //    }).ToList();
        //}
    }
}
