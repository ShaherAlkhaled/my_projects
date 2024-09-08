using FreshMvvm;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class FishesViewModel: FreshBasePageModel
    {

        protected readonly ICategoryService _categoryService;
        protected readonly IFishService _fishService;
        protected readonly IAccountService _accountService;
        private long id;
        public FishesViewModel(ICategoryService categoryService, IFishService fishService, IAccountService accountService)
        {
            _categoryService = categoryService;
            _fishService = fishService;
            _accountService = accountService;
        }

        private ObservableCollection<Fish> fishsByCategory;

        public ObservableCollection<Fish> FishsByCategory
        {
            get { return fishsByCategory; }
            set
            {
                fishsByCategory = value;
                RaisePropertyChanged(nameof(FishsByCategory));
            }
        }



        public override async void Init(object initData)
        {
            FishsByCategory = null;
            if (initData != null)
            {
                this.id = (long)initData;
                try
                {

                    var fishByCategory = await _categoryService.GetFishesByCategoryIdAsync(id);
                    FishsByCategory = new ObservableCollection<Fish>(fishByCategory);
                }
                catch (Exception ex)
                {
                    await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

                }
            }
            else
            {
                try
                {

                    var fishes = await _fishService.Get();
                    FishsByCategory = new ObservableCollection<Fish>(fishes.Skip(0).Take(10));
                }
                catch (Exception ex)
                {
                    await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

                }
            }
              

            
       
        }
        public override async void ReverseInit(object returnedData)
        {
            
            var id = (long)returnedData;
            try
            {
                FishsByCategory = null;
                var fishByCategory = await _categoryService.GetFishesByCategoryIdAsync(id);
                FishsByCategory = new ObservableCollection<Fish>(fishByCategory);
            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

            }
        }
      

        public ICommand ViewFishCommand => new Command<Fish>(
                async (Fish fish) => {
                    await CoreMethods.PushPageModel<FishViewModel>(fish.Id);
                });
        public ICommand AddCommand => new Command(
                async () => {
                    await CoreMethods.PushPageModel<CUFishViewModel>();
                });
        public ICommand LougoutCommand => new Command(
               async () => {
                   await _accountService.Logout();
                   await CoreMethods.PushPageModel<LoginViewModel>(false);

               });
        public ICommand GoBackCommand => new Command(
             async () => {
                 await CoreMethods.PushPageModel<CategoriesViewModel>(this.id);
             });

    }
}
