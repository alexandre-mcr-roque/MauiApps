namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyPage());
            //var navPage = new NavigationPage(new MyPage());

            //navPage.BarBackground = Colors.Yellow;
            //navPage.BarTextColor = Colors.Blue;

            //MainPage = new TabbedPageDemo();
        }
    }
}
