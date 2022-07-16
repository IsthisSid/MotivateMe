using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MotivateMe
{
    public partial class OptionsPage : ContentPage
    {
        public OptionsPage()
        {
            InitializeComponent();
            BackgroundColor = Color.AliceBlue;
        }

        //Send user the the previous page 
        async void Back_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void todo_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FunFactsTabbedPage());
        }

        async void learn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RandomFacts());
        }

        async void exercise_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ExercisePage());
        }
    }
}

