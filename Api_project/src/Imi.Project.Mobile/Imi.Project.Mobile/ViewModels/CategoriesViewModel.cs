using FreshMvvm;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class CategoriesViewModel : FreshBasePageModel
    {
        protected readonly ICategoryService _categories;
        protected readonly IAccountService _accountService;


        public CategoriesViewModel(ICategoryService allCategories, IAccountService accountService)
        {
            _categories = allCategories;
            _accountService = accountService;
        }



        private ObservableCollection<Category> categories;

        public ObservableCollection<Category> Categories
        {
            get { return categories; }
            set 
            { 
                categories = value;
                RaisePropertyChanged(nameof(Categories));
            }
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {

            try
            {
                Categories = null;
                var seedingCategories = await _categories.Get();
                Categories = new ObservableCollection<Category>(seedingCategories);
            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");
            }
            base.ViewIsAppearing(sender, e);
        }
        public ICommand ViewFishByCategoryCommand => new Command<long>(
                 async (Id) => {
                     await CoreMethods.PushPageModel<FishesViewModel>(Id);
                 });
        public ICommand LougoutCommand => new Command(
              async () => {
                  await _accountService.Logout();
                  await CoreMethods.PushPageModel<LoginViewModel>(false);
              });

    }
}

