using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FishesPage : ContentPage
    {
        public FishesPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewModel = (FishesViewModel)BindingContext;
            var fish = (Fish)e.Item;

            //pass control to the View Model (and give it the Id)
            viewModel.ViewFishCommand.Execute(fish);
        }
    }
}