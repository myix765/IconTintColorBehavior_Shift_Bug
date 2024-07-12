namespace IconTintColorBehavior_Shift_Bug
{
    public partial class MainPage : ContentPage
    {
        int tinted_count = 0;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ToggleSourceButtonTinted_Clicked(object sender, EventArgs e)
        {
            if (tinted_count % 2 == 0)
            {
                ToggleSourceButton_Tinted.Source = "dotnet_racebot.png";
            }
            else {
                ToggleSourceButton_Tinted.Source = "dotnet_bot.png";
            }

            tinted_count++;
        }

        private void ToggleSourceButton_Clicked(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                ToggleSourceButton.Source = "dotnet_racebot.png";
            }
            else
            {
                ToggleSourceButton.Source = "dotnet_bot.png";
            }

            count++;
        }
    }

}
