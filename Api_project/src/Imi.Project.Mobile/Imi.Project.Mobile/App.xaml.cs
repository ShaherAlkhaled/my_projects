using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Infrastructure;
using Imi.Project.Mobile.Pages;
using Imi.Project.Mobile.ViewModels;
using System;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjIzMTg1QDMyMzAyZTMxMmUzMEJiYWdlUjVsQjhXTmlISG1YeXBVYmNOYTFtVkhyUHpCa3cyRXVpS05ncHc9");
            ServicePointManager.ServerCertificateValidationCallback +=
               (sender, cert, chain, sslPolicyErrors) =>
               true;
            FreshIOC.Container.Register<IAccountService>(new AccountService());
            FreshIOC.Container.Register<ICategoryService>(new CategoryService());
            FreshIOC.Container.Register<IFishService>(new FishService());
            FreshIOC.Container.Register<IOriginCountryService>(new OriginCountryService());
            FreshIOC.Container.Register<IFishProcessingService>(new FishProcessingService());
            FreshIOC.Container.Register<IGameService,GameService>().AsMultiInstance();
            InitializeComponent();
            MainPage = new FreshNavigationContainer(
                FreshPageModelResolver.ResolvePageModel<LoginViewModel>()
            );
        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
