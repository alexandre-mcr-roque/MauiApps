namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MinhaPagina());

            navPage.BarBackground = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            MainPage = new TabbedPageDemo();
        }
    }
}
