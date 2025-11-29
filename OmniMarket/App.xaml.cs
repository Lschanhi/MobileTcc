namespace OmniMarket
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#0E0E0E"),
                BarTextColor = Color.FromHex("#D4AF37")
            };
        }
    }
}
