using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TechCart
{
    public partial class MasterPage : MasterDetailPage
    {
        public List<MasterPageModel> MenuList { get; set; }
        public MasterPage()
        {
            InitializeComponent();
            MenuList = new List<MasterPageModel>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection

            var page1 = new MasterPageModel() { Title = "NEWS", Icon = "", TargetType = typeof(DashBoardPage) };
            var page2 = new MasterPageModel() { Title = "HEALTH", Icon = "", TargetType = typeof(DashBoardPage) };
            var page3 = new MasterPageModel() { Title = "TECHNOLOGY", Icon = "", TargetType = typeof(DashBoardPage) };
            var page4 = new MasterPageModel() { Title = "INTERVIEWS", Icon = "", TargetType = typeof(DashBoardPage) };
            var page5 = new MasterPageModel() { Title = "JOBS", Icon = "", TargetType = typeof(DashBoardPage) };

            // Adding menu items to menuList
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);



            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(DashBoardPage)));


        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageModel)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;


        }
    }
}
