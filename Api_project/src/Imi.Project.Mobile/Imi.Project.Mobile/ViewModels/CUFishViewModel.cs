using FreshMvvm;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Validators;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class CUFishViewModel: FreshBasePageModel
    {
        protected readonly IFishService _fishService;
        protected readonly ICategoryService _categoryService;
        protected readonly IOriginCountryService _originCountryService;
        protected readonly IFishProcessingService _fishProcessingService;
        protected readonly IAccountService _accountService;
       
        private Fish currentFish;
        protected readonly FishValidator validator;



        public CUFishViewModel(IFishService fishService, ICategoryService categoryService, IOriginCountryService originCountryService, IFishProcessingService fishProcessingService, IAccountService accountService)
        {
            _fishService = fishService;
            _categoryService = categoryService;
            _originCountryService = originCountryService;
            _fishProcessingService = fishProcessingService;
            validator = new FishValidator();
            _accountService = accountService;
        }


        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(); }
        }
        private bool isEdit;

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; RaisePropertyChanged(); }
        }

        private string pageTitle;

        public string PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                RaisePropertyChanged();
            }
        }
        private decimal maxWeight;
        public decimal MaxWeight
        {
            get { return maxWeight; }
            set
            {
                maxWeight = value;
                RaisePropertyChanged();
            }
        }
        private decimal minWeigth;

        public decimal MinWeigth
        {
            get { return minWeigth; }
            set
            {
                minWeigth = value;
                RaisePropertyChanged();
            }
        }

        private string urlImage;

        public string UrlImage
        {
            get { return urlImage; }
            set
            {
                urlImage = value;
                RaisePropertyChanged();
            }
        }


        private DateTime dateOfArrival;

        public DateTime DateOfArrival
        {
            get { return dateOfArrival; }
            set
            {
                value = DateTime.Now;

                dateOfArrival = value;
                RaisePropertyChanged();
            }
        }
        private Category selectedcategory;

        public Category Selectedcategory
        {
            get { return selectedcategory; }
            set { selectedcategory = value; RaisePropertyChanged(nameof(Selectedcategory)); }
        }
        private OriginCountry selectedCountry;

        public OriginCountry SelectedCountry
        {
            get { return selectedCountry; }
            set { selectedCountry = value; RaisePropertyChanged(nameof(SelectedCountry)); }
        }

        private ObservableCollection<FishProcessing> selectedFishProcessing;

        public ObservableCollection<FishProcessing> SelectedFishProcessing
        {
            get { return selectedFishProcessing; }
            set
            {
                selectedFishProcessing = value;
                RaisePropertyChanged(nameof(SelectedFishProcessing));
            }
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


        private ObservableCollection<OriginCountry> countries;

        public ObservableCollection<OriginCountry> Countries
        {
            get { return countries; }
            set
            {
                countries = value;
                RaisePropertyChanged(nameof(Countries));
            }
        }

        private ObservableCollection<FishProcessing> fishProcessings;

        public ObservableCollection<FishProcessing> FishProcessings
        {
            get { return fishProcessings; }
            set
            {
                fishProcessings = value;
                RaisePropertyChanged(nameof(FishProcessings));
            }
        }




        private string nameError;
        public string NameError
        {
            get { return nameError; }
            set
            {
                nameError = value;
                RaisePropertyChanged();
            }
        }
        private string priceError;
        public string PriceError
        {
            get { return priceError; }
            set
            {
                priceError = value;
                RaisePropertyChanged();
            }
        }

        private string maxWeightError;
        public string MaxWeightError
        {
            get { return maxWeightError; }
            set
            {
                maxWeightError = value;
                RaisePropertyChanged();
            }
        }

        private string minWeigthError;
        public string MinWeigthError
        {
            get { return minWeigthError; }
            set
            {
                minWeigthError = value;
                RaisePropertyChanged();
            }
        }

        private string categoryError;
        public string CategoryError
        {
            get { return categoryError; }
            set
            {
                categoryError = value;
                RaisePropertyChanged();
            }
        }
        private string originCountryError;
        public string OriginCountryError
        {
            get { return originCountryError; }
            set
            {
                originCountryError = value;
                RaisePropertyChanged();
            }
        }


        private string dateOfArrivalError;
        public string DateOfArrivalError
        {
            get { return dateOfArrivalError; }
            set
            {
                dateOfArrivalError = value;
                RaisePropertyChanged();
            }
        }



        public async override void Init(object initData)
        {
            var fish = initData as Fish;
            if(fish != null)
            {
               
                IsEdit = true;
                PageTitle = "Vis wijzigen";
                currentFish = await _fishService.GetById(fish.Id);
                Id= currentFish.Id;
                Name = currentFish.Name;
                Price= currentFish.Price;
                MaxWeight= currentFish.MaxWeight;
                MinWeigth = currentFish.MinWeigth;
                DateOfArrival = currentFish.DateOfArrival;
             
               

            }
            else
            {
                IsEdit = false;
                PageTitle = "Vis Toevoegen";
            }
                FullCategoryAndOriginOfCountry();

            DefaultLableErrorState();

        }
     
        public ICommand SaveCommand => new Command(async () =>
        {
            if (!isEdit)
            {
                currentFish = new Fish()
                {
                    Name = this.Name,
                    Price = this.Price,
                    MaxWeight = this.MaxWeight,
                    MinWeigth = this.MinWeigth,
                    DateOfArrival = this.DateOfArrival,
                    CategoryId = Selectedcategory.Id,
                    OriginCountryId = SelectedCountry.Id,
                    
                };
                        var validationResult = validator.Validate(currentFish);
                        DefaultLableErrorState();
                        if (validationResult.IsValid)
                        {

                           await _fishService.Add(currentFish);
                           await CoreMethods.DisplayAlert("Error", $"{Name} wordt met successfully toegevoegd", "Ok");
                          await CoreMethods.PushPageModel<FishesViewModel>(currentFish.CategoryId);
                        }
                else
                {
                    Validation(validationResult);

                }
            }
            else
            {
                currentFish.Name = Name;
                currentFish.Price = Price;
                currentFish.MaxWeight = MaxWeight;
                currentFish.MinWeigth = MinWeigth;
                currentFish.CategoryId = Selectedcategory.Id;
                currentFish.OriginCountryId = SelectedCountry.Id;
                currentFish.DateOfArrival = DateOfArrival;
                var validationResult = validator.Validate(currentFish);
                DefaultLableErrorState();
                if (validationResult.IsValid)
                {

                    await _fishService.Update(currentFish);
                    await CoreMethods.DisplayAlert("Error", $"{Name} wordt met successfully gewijzigd", "Ok");
                    await CoreMethods.PushPageModel<FishesViewModel>(currentFish.CategoryId);
                }
                else
                {
                    Validation(validationResult);

                }
            }
        });


        private void Validation(FluentValidation.Results.ValidationResult validationResult)
        {
            foreach (var failure in validationResult.Errors)
            {
                if (failure.PropertyName == nameof(Fish.Name))
                {
                    NameError = failure.ErrorMessage;
                }
                else if (failure.PropertyName == nameof(Fish.Price))
                {
                    PriceError = failure.ErrorMessage;
                }
                else if (failure.PropertyName == nameof(Fish.MaxWeight))
                {
                    MaxWeightError = failure.ErrorMessage;
                }
                else if (failure.PropertyName == nameof(Fish.MinWeigth))
                {
                    MinWeigthError = failure.ErrorMessage;
                }
                else if (failure.PropertyName == nameof(Fish.CategoryId))
                {
                    CategoryError = failure.ErrorMessage;
                }
                else if (failure.PropertyName == nameof(Fish.OriginCountryName))
                {
                    OriginCountryError = failure.ErrorMessage;
                }
                else
                {
                    throw new NotImplementedException($"The property {failure.PropertyName} is not handled in the viewmodel");
                }
            }
        }

        private void DefaultLableErrorState()
        {
            NameError = default;
            PriceError = default;
            MaxWeightError = default;
            MinWeigthError = default;
            CategoryError = default;
            OriginCountryError= default;

        }

        private async void FullCategoryAndOriginOfCountry()
        {
            try
            {
                var seedingCategories = await _categoryService.Get();
                Categories = null;
                Categories = new ObservableCollection<Category>(seedingCategories);
                var seedingCountry = await _originCountryService.Get();
                Countries = null;
                Countries = new ObservableCollection<OriginCountry>(seedingCountry);
                var processing = await _fishProcessingService.Get();
                FishProcessings = null;
                FishProcessings = new ObservableCollection<FishProcessing>(processing);
                Selectedcategory=Categories.ElementAt(0);
                SelectedCountry=Countries.ElementAt(0);

            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");
            }
        }
        public ICommand LougoutCommand => new Command(
            async () => {
                await _accountService.Logout();
                await CoreMethods.PushPageModel<LoginViewModel>(false);

            });

        public ICommand GoBackCommand => new Command(
           async () => {
               await CoreMethods.PopPageModel(false);
           });

    }
}


