using Imi.Project.Mobile.Constants;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Infrastructure
{
    public class CategoryService : ICategoryService
    {
        private readonly string _baseUri;

        public CategoryService()
        {
            _baseUri = Url.BaseUri;
        }

        public async Task<IQueryable<Category>> Get()
        {
            var categories = await WebApiClient
                                   .GetApiResult<List<Category>>($"{_baseUri}Categories");
            return categories.AsQueryable();       
                
        }
        public async Task<Category> GetById(long id)
        {
            var category = await WebApiClient.GetApiResult<Category>($"{_baseUri}Categories/{id}");
            return await Task.FromResult(category);
        }

        public async Task<IQueryable<Fish>> GetFishesByCategoryIdAsync(long id)
        {
            var fishsByCategory = await WebApiClient
                                                 .GetApiResult<IEnumerable<Fish>>($"{_baseUri}Categories/{id}/Fishs");

            return fishsByCategory.AsQueryable();
        }


        //private static List<Category> _categories = new List<Category>()
        //{
        //    new Category()
        //    {
        //        Id =1,
        //        Name ="PlateFish",
        //    },
        //     new Category()
        //    {
        //        Id =2,
        //        Name ="Rond Fish",
        //    },
        //     new Category()
        //    {
        //        Id =3,
        //        Name ="Mosselen",
        //    },
        //    new Category()
        //    {
        //        Id =4,
        //        Name ="Schaal & Weekdieren",
        //    },
        //     new Category()
        //    {
        //        Id =5,
        //        Name ="Gerookt vis",
        //    },
        //     new Category()
        //    {
        //        Id =6,
        //        Name ="Diepvries",
        //    },
        //   new Category()
        //    {
        //        Id =7,
        //        Name ="Gekweekte vis",
        //    },
        //     new Category()
        //    {
        //        Id =8,
        //        Name ="Verse vis",
        //    },
        //     new Category()
        //    {
        //        Id =9,
        //        Name ="Diverse",
        //    },


        //        new Category()
        //    {
        //        Id =10,
        //        Name ="Fileren Vis",
        //    },
        //     new Category()
        //    {
        //        Id =11,
        //        Name ="Kreeft",
        //    },

        //};



    }
}
