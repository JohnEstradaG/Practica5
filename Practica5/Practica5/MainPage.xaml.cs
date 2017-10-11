using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica5
{
    public partial class MainPage : CarouselPage
    {
        public int Num1;
        public int Num2;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Gustar1_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar1.BackgroundColor = Color.Blue;
            Gustar1.TextColor = Color.White;
            NoGustar1.IsEnabled = false;
            Gustar1.IsEnabled = false;
        }

        private void NoGustar1_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar1.TextColor = Color.White;
            NoGustar1.BackgroundColor = Color.Red;
            NoGustar1.IsEnabled = false;
            Gustar1.IsEnabled = false;
        }

        private void Gustar2_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar2.BackgroundColor = Color.Blue;
            Gustar2.TextColor = Color.White;
            NoGustar2.IsEnabled = false;
            Gustar2.IsEnabled = false;
        }

        private void NoGustar2_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar2.TextColor = Color.White;
            NoGustar2.BackgroundColor = Color.Red;
            NoGustar2.IsEnabled = false;
            Gustar2.IsEnabled = false;
        }

        private void Gustar3_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar3.BackgroundColor = Color.Blue;
            Gustar3.TextColor = Color.White;
            NoGustar3.IsEnabled = false;
            Gustar3.IsEnabled = false;
        }

        private void NoGustar3_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar3.TextColor = Color.White;
            NoGustar3.BackgroundColor = Color.Red;
            NoGustar3.IsEnabled = false;
            Gustar3.IsEnabled = false;
        }

        private void Gustar4_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar4.BackgroundColor = Color.Blue;
            Gustar4.TextColor = Color.White;
            NoGustar4.IsEnabled = false;
            Gustar4.IsEnabled = false;
        }

        private void NoGustar4_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar4.TextColor = Color.White;
            NoGustar4.BackgroundColor = Color.Red;
            NoGustar4.IsEnabled = false;
            Gustar4.IsEnabled = false;
        }

        private void Gustar5_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar5.BackgroundColor = Color.Blue;
            Gustar5.TextColor = Color.White;
            NoGustar5.IsEnabled = false;
            Gustar5.IsEnabled = false;
        }

        private void NoGustar5_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar5.TextColor = Color.White;
            NoGustar5.BackgroundColor = Color.Red;
            NoGustar5.IsEnabled = false;
            Gustar5.IsEnabled = false;
        }

        private void Gustar6_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar6.BackgroundColor = Color.Blue;
            Gustar6.TextColor = Color.White;
            NoGustar6.IsEnabled = false;
            Gustar6.IsEnabled = false;
        }

        private void NoGustar6_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar6.TextColor = Color.White;
            NoGustar6.BackgroundColor = Color.Red;
            NoGustar6.IsEnabled = false;
            Gustar6.IsEnabled = false;
        }

        private void Gustar7_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar7.BackgroundColor = Color.Blue;
            Gustar7.TextColor = Color.White;
            NoGustar7.IsEnabled = false;
            Gustar7.IsEnabled = false; ;
        }

        private void NoGustar7_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar7.TextColor = Color.White;
            NoGustar7.BackgroundColor = Color.Red;
            NoGustar7.IsEnabled = false;
            Gustar7.IsEnabled = false;
        }

        private void Gustar8_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar8.BackgroundColor = Color.Blue;
            Gustar8.TextColor = Color.White;
            NoGustar8.IsEnabled = false;
            Gustar8.IsEnabled = false;
        }

        private void NoGustar8_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar8.TextColor = Color.White;
            NoGustar8.BackgroundColor = Color.Red;
            NoGustar8.IsEnabled = false;
            Gustar8.IsEnabled = false;
        }

        private void Gustar9_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar9.BackgroundColor = Color.Blue;
            Gustar9.TextColor = Color.White;
            NoGustar9.IsEnabled = false;
            Gustar9.IsEnabled = false;
        }

        private void NoGustar9_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar9.TextColor = Color.White;
            NoGustar9.BackgroundColor = Color.Red;
            NoGustar9.IsEnabled = false;
            Gustar9.IsEnabled = false;
        }

        private void Gustar10_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(Gustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            Gustados.Text = Convert.ToString(res);
            Gustar10.BackgroundColor = Color.Blue;
            Gustar10.TextColor = Color.White;
            NoGustar10.IsEnabled = false;
            Gustar10.IsEnabled = false;
        }

        private void NoGustar10_Clicked(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt16(NoGustados.Text);
            Num2 = 1;
            int res = Num1 + Num2;
            NoGustados.Text = Convert.ToString(res);
            NoGustar10.TextColor = Color.White;
            NoGustar10.BackgroundColor = Color.Red;
            NoGustar10.IsEnabled = false;
            Gustar10.IsEnabled = false;
        }
    }
}
