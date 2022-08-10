namespace GPSMobile.BA
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked 312312 {count} time";
            else
                CounterBtn.Text = $"Clicked áđâsdá {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}