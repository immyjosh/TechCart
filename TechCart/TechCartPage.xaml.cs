using Xamarin.Forms;

namespace TechCart
{
    public partial class TechCartPage : ContentPage
    {
        public TechCartPage()
        {
            InitializeComponent();
        }
        void Handle_Tapped1(object sender, System.EventArgs e)
        {


            up.IsVisible = true;

        }
        void Handle_Tapped2(object sender, System.EventArgs e)
        {


            down.IsVisible = true;

        }
    }
}
