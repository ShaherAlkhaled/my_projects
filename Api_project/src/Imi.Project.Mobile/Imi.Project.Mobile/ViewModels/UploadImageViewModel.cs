using FreshMvvm;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class UploadImageViewModel:FreshBasePageModel
    {
        private MediaFile _mediaFile;
        protected readonly IFishService _fishService;
        protected IAccountService _accountService;

        public UploadImageViewModel(IFishService fishService, IAccountService accountService)
        {
            _fishService = fishService;
            _accountService = accountService;
        }


        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(); }
        }

        private Fish currentFish;

        public Fish CurrentFish
        {
            get { return currentFish; }
            set { currentFish = value; RaisePropertyChanged(); }
        }
        public  override async void Init(object initData)
        {
            CurrentFish = null;
            Id = (long)initData;
            CurrentFish = await _fishService.GetById(Id);
        }
       
      

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; 
                RaisePropertyChanged(); }
        }
        private ImageSource fileImage;

        public ImageSource FileImage
        {
            get { return fileImage; }
            set { fileImage = value; 
                RaisePropertyChanged(); }
        }


        public ICommand PickPhotoCommand => new Command(async () =>
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await CoreMethods.DisplayAlert("No PickPhoto", ":( No PickPhoto available.", "OK");
                return;
            }
            _mediaFile = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.Medium,
                CompressionQuality=40,
                
            
            });


            if (_mediaFile == null)
            {

                return;
            }
            else
            {


                try
                {
                    FileName = Path.GetFileName(_mediaFile.Path);
                    var imageSource=  ImageSource.FromFile(_mediaFile.Path);
                    if (imageSource != null)
                    {
                       FileImage =  imageSource;
                    }
                    else
                    {

                    await CoreMethods.DisplayAlert("Error", "Deze App don't support this image", "Ok");
                    }
            
                }
                catch(Exception ex)
                {
                    await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

                }



            }
        });

        public ICommand TakePhotoCommand => new Command(async () =>
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await CoreMethods.DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            _mediaFile = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                PhotoSize = PhotoSize.Medium,
                Directory = "Sample",
                Name = "myImage.jpg",
                CompressionQuality = 40,
            }) ;

            if (_mediaFile == null)
            {

                return;
            }
            else
            {
                try
                {
                    FileName = Path.GetFileName(_mediaFile.Path);
                    var imageSource = ImageSource.FromFile(_mediaFile.Path);
                    if (imageSource != null)
                    {
                        FileImage = imageSource;
                    }
                    else
                    {

                        await CoreMethods.DisplayAlert("Error", "Deze App don't support this image", "Ok");
                    }

                }
                catch (Exception ex)
                {
                    await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");

                }
            }


        });
        public ICommand UploadPhotoCommand => new Command(async () =>
        {
            if (_mediaFile != null)
            {
            var content = _mediaFile.GetStream();
                await _fishService.UploadImage(currentFish.Id, content, FileName);
                await CoreMethods.PushPageModel<FishesViewModel>(CurrentFish.CategoryId, false);
            }
            else
            {
                await CoreMethods.DisplayAlert("Error", "Please Enter image", "Ok");
            }
        });

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
