using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBoxColor.ViewModels
{
    public partial class HSLViewModel : ObservableObject
    {
        [ObservableProperty]
        private double hue;
        [ObservableProperty]
        private double saturation;
        [ObservableProperty]
        private double luminosity;
        [ObservableProperty]
        private Color color;

        public HSLViewModel()
        {         
        }          
        partial void OnHueChanged(double value)
        {
            SetNewColor();
        }
        partial void OnSaturationChanged(double value)
        {
            SetNewColor();
        }
        partial void OnLuminosityChanged(double value)
        {
            SetNewColor();
        }

        private void SetNewColor()
        {
            Color = Color.FromHsla(Hue, Saturation, Luminosity);
        }
    }
}
