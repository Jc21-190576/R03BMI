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
            creater.Text = "JK3A30 野村 竜生";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double weight, height, bmi;

            height = double.Parse(heighit.Text);
            if (height > 10)
            {
                height = height / 100;
            }

            weight = double.Parse(weighit.Text);
            if (weight > 1000)
            {
                weight = weight / 1000;
            }
            
            bmi = weight / (height * height);
            double BMI = Math.Round(bmi);

            if (bmi < 18.5)
            {
                result.Text = "身長" + height + ",体重" + weight + "の人のBMIは、" + BMI + "低体重(瘦せ)です";
            }
            else if (bmi < 25)
            {
                result.Text = "身長" + height + ",体重" + weight + "の人のBMIは、" + BMI + "普通体重です";
            }
            else if (bmi < 30)
            {
                result.Text = "身長" + height + ",体重" + weight + "の人のBMIは、" + BMI + "肥満(1度)です";
            }
            else if (bmi < 35)
            {
                result.Text = "身長" + height + ",体重" + weight + "の人のBMIは、" + BMI + "肥満(2度)です";
            }else if (bmi < 40)
            {
                result.Text = "身長" + height + ",体重" + weight + "の人のBMIは、" + BMI + "肥満(3度)です";
            }
            else
            {
                result.Text = "身長" + height + ",体重" + weight + "の人のBMIは、" + BMI + "肥満(4度)です";
            }
        }
    }
}
