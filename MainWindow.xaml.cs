using System;
using System.Windows;
using System.Text;
using System.Windows.Input;

namespace RanNameGen
{
    public partial class MainWindow : Window
    {
        public static string[] swearWord1 = new string[] { " Cunt"," Fuck"," Motherfucking"," Bastard"," Beaver"," Bellend"," Clunge"," Cock"," Dick"," Dickhead"," Fanny"," Flaps"," Gash"," Knob"
                                                            ," Minge"," Prick"," Punani"," Pussy"," Snatch"," Twat","n Arsehole"," Balls"," Bitch"," Bollocks"," Bullshit"," Shit"," Tits","n Arse",
                                                            " Bugger"," Cow"," Crap"," Damn"," Git"," Minger"," Bum","n Ethan", " Twit", " Donkey", " Dog", " Knob", " Bottom-Feeding"};
        public static string[] swearWord2 = new string[] { "Face", "Fart", "Head", "Waffle", "Pancake", "Bandit", "Licker", "Sucker", "Twinkler", "Sprinkle", "Delinquent", "Toucher", "Feeler"
                                                            , "Master", "Slave", "Jockey", "Stingray"};
        public string swear;
        //static Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            FirstNameText.Focus();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        public void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            ShowInsult();
        }
        private void ShowInsult()
        {
            SwearDisplay.Text = (GetInsult());
        }
        private string GetInsult()
        {
            string firstName = FirstNameText.Text;

            if (firstName == "Gordo" | firstName == "gordo")
                return "Hello Gordo, you are a fucking legend!";
            else if (firstName == "Dylan" | firstName == "dylan" | firstName == "Ethan" | firstName == "ethan" | firstName == "Jamie" | firstName == "jamie")
                return String.Format("Hello {0}, you are a Bottom Feeding Stingray", firstName);
            else if (firstName == "Lorenzo" | firstName == "lorenzo")
                return String.Format("Hello {0}, you are a Malnourished Stingray", firstName);
            else if (string.IsNullOrWhiteSpace(firstName))
                return "Enter your name dipshit...";
            else
                return String.Format("Hello {0}, you are a{1} {2}", firstName, swearWord1[rnd.Next(swearWord1.Length)], swearWord2[rnd.Next(swearWord2.Length)]);
        }
        public string GetNumInsult()
        {
            string finalSwear = "";
            string swearNum = (NumberGenerator.Text);
            StringBuilder stringBuilder = new StringBuilder();
            int i = 1;

            if (swearNum == "69")
            {
                return "69... hah! nice!!!";
            }
            else if (string.IsNullOrWhiteSpace(NumberGenerator.Text))
            {
                return "Enter a number dipshit...";
            }
            else
            {
                try
                {
                    int swearNum2 = Convert.ToInt32(NumberGenerator.Text);
                    while (i <= swearNum2)
                    {
                        i++;
                        finalSwear = String.Format("{0}{1}Hello, you are a{2} {3}", finalSwear, Environment.NewLine, swearWord1[rnd.Next(swearWord1.Length)], swearWord2[rnd.Next(swearWord2.Length)]);
                    }
                    return finalSwear;
                }
                catch (FormatException)
                {
                    string catch1 = "Enter a number, you twit!";
                    return catch1;
                }
            }
        }
        public void SubmitNumButton_Click(object sender, RoutedEventArgs a)
        {
            SwearDisplay.Text = (GetNumInsult());
        }
        private void FirstNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                SubmitButton_Click(sender, e);
            }
        }
        private void NumberGenerator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                SubmitNumButton_Click(sender, e);
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}