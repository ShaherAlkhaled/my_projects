using FreshMvvm;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class FishViewModel : FreshBasePageModel
    {
        protected readonly IFishService _fishService;
        protected readonly IAccountService _accountService;

        public FishViewModel(IFishService fishService, IAccountService accountService)
        {
            _fishService = fishService;
            _accountService = accountService;
        }



        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }

        private string imageUrl;

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; RaisePropertyChanged(); }
        }

        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; RaisePropertyChanged(); }
        }

        private string originCountry;

        public string OriginCountry
        {
            get { return originCountry; }
            set { originCountry = value; RaisePropertyChanged(); }
        }


        private string minWeigth;

        public string MinWeigth
        {
            get { return minWeigth; }
            set { minWeigth = value; RaisePropertyChanged(); }
        }


        private string maxWeigth;

        public string MaxWeigth
        {
            get { return maxWeigth; }
            set { maxWeigth = value; RaisePropertyChanged(); }
        }

        private Fish currentFish;

        public Fish CurrentFish
        {
            get { return currentFish; }
            set { currentFish = value; RaisePropertyChanged(); }
        }

        public bool isAdmin;
        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
                RaisePropertyChanged();
            }
        }
        public override async void Init(object initData)
        {
            Rest();
            await CheckAdmin();
            var id = (long)initData;

            try
            {
                CurrentFish = await _fishService.GetById(id);
                Name = $"Naam : {CurrentFish.Name}";
                ImageUrl = CurrentFish.UrlImage;
                Price = $"Prijs : {CurrentFish.Price} €";
                OriginCountry = $"Afkomstig : {CurrentFish.OriginCountryName}";
                MinWeigth = $"Min gewicht  :{CurrentFish.MinWeigth} Kg";
                MaxWeigth = $"Max gewicht : {CurrentFish.MaxWeight}  Kg";
            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

            }
        }
        public override async void ReverseInit(object returnedData)
        {
            Rest();
            await CheckAdmin();
            var id = (long)returnedData;
            try
            {
                CurrentFish = await _fishService.GetById(id);
                Name = $"Naam : {CurrentFish.Name}";
                ImageUrl = CurrentFish.UrlImage;
                Price = $"Prijs : {CurrentFish.Price} €";
                OriginCountry = $"Afkomstig : {CurrentFish.OriginCountryName}";
                MinWeigth = $"Min gewicht  :{CurrentFish.MinWeigth} Kg";
                MaxWeigth = $"Max gewicht : {CurrentFish.MaxWeight}  Kg";
            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

            }
        }

        public ICommand GoBackCommand => new Command(
                async () => {
                    await CoreMethods.PushPageModel<FishesViewModel>(currentFish.CategoryId, false);
                });

        public ICommand EditFishCommand => new Command(
              async () => {

                  await CoreMethods.PushPageModel<CUFishViewModel>(CurrentFish);
              });
        public ICommand DeleteFishCommand => new Command(
              async () => {
                  try
                  {

                      if (await CheckAdmin())
                      {
                          if(await CoreMethods.DisplayAlert("Bevestigen", "Ben je zeker?", "Ja", "Nee"))
                          {
                              await _fishService.Delete(CurrentFish.Id);
                              await CoreMethods.PopPageModel(CurrentFish.CategoryId);
                          }
                          
                      }
                      else
                      {
                          await CoreMethods.DisplayAlert("Error", "Enkel admin kan de vis verwijderen", "Ok");
                      }
                  }
                  catch (Exception ex)
                  {
                      await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

                  }
              });

        public ICommand UploadImageFishCommand => new Command(
             async () => {

                 await CoreMethods.PushPageModel<UploadImageViewModel>(CurrentFish.Id);
             });

        private void Rest()
        {
            Name = null;
            Price = null;
            ImageUrl = null;
            MaxWeigth = null;
            MinWeigth = null;
            OriginCountry = null;
            CurrentFish = null;
        }

        private  async Task<bool> CheckAdmin()
        {
            var token = await SecureStorage.GetAsync("token");

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.ReadJwtToken(token);

            var admin =  securityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            if (admin == "Admin")
            {
                IsAdmin = true;
            }
            else
            {
                IsAdmin = false;
            }
            return admin == "Admin";
        }
        public ICommand LougoutCommand => new Command(
            async () => {
                await _accountService.Logout();
                await CoreMethods.PushPageModel<LoginViewModel>(false);
            });
        public ICommand AddCommand => new Command(
             async () => {
                 await CoreMethods.PushPageModel<CUFishViewModel>();
             });


    }
}