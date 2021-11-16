using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A00 野村 竜生";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Height=heighit.Text;
            double h=double.Parse(Height);
            if (h < 10)
            {
                h=h/100;
            }
           
            string Weight=weighit.Text;
            double w=double.Parse(Weight);
            double cw = Math.Floor(w);

            double bmi = h / Math.Pow(cw, 2);

            String BMI = bmi.ToString();

            result.Text = BMI;
        }
    }
}
