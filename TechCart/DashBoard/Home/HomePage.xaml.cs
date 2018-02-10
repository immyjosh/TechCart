using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TechCart
{
    public partial class HomePage : ContentPage
    {
        ObservableCollection<HomeModel> Trendings;
        public HomePage()
        {
            InitializeComponent();
            LoadTrendingData();
        }
        void LoadTrendingData()
        {
            Trendings = new ObservableCollection<HomeModel>()
            {
                new HomeModel() { Title = "Categories", ImageUrl = "http://www.pictureicon.com/images/categories-icon-png-extended-category-icons.png"},
                new HomeModel() { Title = "Fashion",  ImageUrl = "http://www.nowtrendingtv.net/wp-content/uploads/2012/07/ntsunglassesmw.jpg"},
                new HomeModel() { Title = "Mobile",  ImageUrl = "http://likhopakistan.com/wp-content/uploads/2015/01/best-mobile-phones2_1.jpg"},
                new HomeModel() { Title = "Electronics",  ImageUrl = "http://www.polytechnichub.com/wp-content/uploads/2017/04/Electronic.jpg"},
                new HomeModel() { Title = "Home & Living",  ImageUrl = "http://candyspelling.com/wp-content/uploads/2015/10/Country-Living-Living-Room.jpg"},
                new HomeModel() { Title = "Kids",  ImageUrl = "https://d3uf2ssic990td.cloudfront.net/images/5031/413b4a3e-5bf8-494b-bfda-ed9488ca3b0d/kids.jpg"},
                new HomeModel() { Title = "Grocery",  ImageUrl = "http://mycitycart.com/wordpress/wp-content/uploads/2015/03/1-composition-with-variety-of-grocery-products-t-monticello1.jpg"}
            };

            HorizontalView.ItemsSource = Trendings;
        }
    }
}
