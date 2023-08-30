namespace DeliveryApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {// Vous pouvez également ouvrir le volet immédiatement après l'avoir activé
            Shell.SetFlyoutBehavior(Application.Current.MainPage, FlyoutBehavior.Locked);
            Shell.SetFlyoutBehavior(Application.Current.MainPage, FlyoutBehavior.Flyout); // Activer le volet latéral
            

        }
    }
}