using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MotivateMe
{

    public partial class ExercisePage : ContentPage
    {

        public ExercisePage()
        {
            InitializeComponent();
        }

        void button_Clicked(object sender, EventArgs e)
        {
            var embeddedImage = new Image { Aspect = Aspect.AspectFill };

            string[] imageNames = new string[]
            {
                "MotivateMe.Images.pinkswirl.png",
                "MotivateMe.Images.exercise.png",
                "MotivateMe.Images.learn.png"
            };

            Random rnd = new Random();
            int index = rnd.Next(imageNames.Length);

            RandomImage.Source = embeddedImage.Source = ImageSource.FromResource($"{imageNames[index]}");

        }
    }
}

