namespace StylesDemos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DynamicStylesView();
        }
    }
}
