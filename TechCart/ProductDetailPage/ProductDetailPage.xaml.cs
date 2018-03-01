using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TechCart
{
    public partial class ProductDetailPage : ContentPage
    {

       // public List<ProductModel> Product { get; set; }
        ObservableCollection<ProductColor> Colors;
        public ProductDetailPage()
        {
            InitializeComponent();
            LoadImageData();
            LoadColorData();

        }
        void LoadImageData()
        {
            this.BindingContext = new ProductModel()
            {
                Prodimage1 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70",
                Prodimage2 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyrfdhpfwz.jpeg?q=70",
                Prodimage3 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsye8zz86fg.jpeg?q=70",
                Prodimage4 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyynexfht6.jpeg?q=70"
            
            
            };
        }
        void LoadColorData()
        {
            Colors = new ObservableCollection<ProductColor>()
            {
                new ProductColor() { formalshoe="https://rukminim1.flixcart.com/image/832/832/jb890nk0/shoe/k/n/5/sokr-brwn-8-deals4you-brown-original-imafymgg9shk6jbq.jpeg?q=70"},
                new ProductColor() { formalshoe="https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70"},

            };

            colordata.ItemsSource = Colors;
        }

       


        void Handle_ItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = e.Item as HomeModel;

        }


        void Handle_Tapped(object sender, System.EventArgs e)
        {


            pallet.IsVisible = !pallet.IsVisible;

        }

        void Handle_image1(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70";
            selectimg1.BackgroundColor = Color.Blue;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        void Handle_image2(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyrfdhpfwz.jpeg?q=70";
            selectimg2.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        void Handle_image3(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsye8zz86fg.jpeg?q=70";
            selectimg3.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg2.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;


        }
        void Handle_image4(object sender, System.EventArgs e)
        {
            selectimg4.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;

            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyynexfht6.jpeg?q=70";


        }

    }
}
