using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MotivateMe
{
    public partial class RandomFacts : ContentPage
    {
        public RandomFacts()
        {
            InitializeComponent();
            BackgroundColor = Color.LightSkyBlue;    
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            string[] facts = new string[] {
                "There is a technical name for the fear of long words. It's called hippopotomonstrosesquippedaliophobia.",
                "Someone actually paid $10,000 for invisible artwork.",
                "A U.S. town had a 3-year-old mayor in 2015.",
                "The Cookie Monster has a real name. It's Sid. No, seriously.",
                "The actual U.S. Centers for Disease Control and Prevention has a real website devoted to zombie preparedness.",
                "You're twice as likely to be killed by a vending machine than a shark",
                "The blob of toothpaste that sits on your toothbrush has a name. It's called a nurdle.",
                "According to a 2014 study published by the LA Times, one in nine Americans think HTML is actually a disease.",
                "In 2012, a man wore 60 shirts and 9 pairs of jeans on an 11-and-a-half hour flight from China to Africa because he didn't want to pay the extra baggage fee.",
                "There's an American town with a population of one."
            };
            Random rnd = new Random();

            int index = rnd.Next(facts.Length);
            DisplayAlert("Random Fact:", $"{facts[index]}", "OK");
        }
    }
}

