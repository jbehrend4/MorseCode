using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        string enteredText = "";
        string outputText = "";

        public MainPage()
        {
            InitializeComponent();
        }


        void typePeriod(object sender, EventArgs e)
        {
            enteredText += ".";
        }
        void typeDash(object sender, EventArgs e)
        {
            enteredText += "-";
        }
        void typeSpace(object sender, EventArgs e)
        {
            char text = Morse.MorseCoder(enteredText);
            outputText += text;
            enteredText = "";
            output.Text = outputText;
        }
    }
}