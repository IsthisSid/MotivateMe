using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MotivateMe
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            var embeddedImage = new Image { Aspect = Aspect.AspectFill };
            InitializeComponent();
            BackgroundImageSource = embeddedImage.Source = ImageSource.FromResource("MotivateMe.Images.pinkswirl.png");            
        }

        //Navigate the user to the next page
        async void DoIt_Clicked(System.Object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new OptionsPage());
        }

        protected override bool OnBackButtonPressed()
        {
            return true; // this will disable the back button functionality on the android when we want the user to navigate within the APP
        }
    }
}

