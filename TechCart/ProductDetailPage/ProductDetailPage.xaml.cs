using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TechCart
{
    public partial class ProductDetailPage : ContentPage
    {
        public List<ProductModel> Product { get; set; }
        ObservableCollection<HomeModel> Trendings;
        public ProductDetailPage()
        {
            InitializeComponent();
            LoadTrendingData();
            this.BindingContext = new
            {
                ImageUrl  = "https://images-na.ssl-images-amazon.com/images/I/81X1jkt8FIL._UX500_.jpg"
            };
        }
       
        void LoadTrendingData()
        {
            Trendings = new ObservableCollection<HomeModel>()
            {
                new HomeModel() {  ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81X1jkt8FIL._UX500_.jpg"},
                new HomeModel() {  ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81KfKJ2SqfL._UX395_.jpg"},
                new HomeModel() {  ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81X1jkt8FIL._UX500_.jpg"},
                new HomeModel() {  ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81KfKJ2SqfL._UX395_.jpg"},

            };

            HorizontalView.ItemsSource = Trendings;
        }

          void Handle_ItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = e.Item as HomeModel;

        }

       
    }
}
