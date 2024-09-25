namespace DiceRoll5A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DiceRoll(object sender, EventArgs e)
        {
            int[] dice = new int[5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                dice[i] = r.Next(1, 7);
            }
            Dice0.Source = "k6_" + dice[0] + ".png";
            Dice1.Source = "k6_" + dice[1] + ".png";
            Dice2.Source = "k6_" + dice[2] + ".png";
            Dice3.Source = "k6_" + dice[3] + ".png";
            Dice4.Source = "k6_" + dice[4] + ".png";
        }

        private void ResetGame(object sender, EventArgs e)
        {
            Dice0.Source = "k6_0.png";
            Dice1.Source = "k6_0.png";
            Dice2.Source = "k6_0.png";
            Dice3.Source = "k6_0.png";
            Dice4.Source = "k6_0.png";
        }
    }
}
