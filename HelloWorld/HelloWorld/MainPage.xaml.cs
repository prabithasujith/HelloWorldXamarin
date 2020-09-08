using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueOfSlider.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}
