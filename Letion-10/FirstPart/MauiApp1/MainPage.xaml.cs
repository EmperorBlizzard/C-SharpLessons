namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            if (count == 10)
                label1.Text = "Wow 10 clicks";
            else if (count == 100)
                label1.Text = "OMG 100 clicks your insane";
            else if (count == 1000)
                label1.Text = "Go touch grass";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}