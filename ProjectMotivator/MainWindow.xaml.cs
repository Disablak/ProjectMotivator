using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ProjectMotivator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rand = new Random();
        List<Quote> quotes = new List<Quote>();
        int randomIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            quotes = QuotesFromData();

            do
            {
                randomIndex = rand.Next(0, quotes.Count);
            }
            while (randomIndex == Properties.Settings.Default.indexLast);
            Properties.Settings.Default.indexLast = randomIndex;
            Properties.Settings.Default.Save();
            ApllyQuote(quotes[randomIndex]);
        }

        List<Quote> QuotesFromData()
        {
            List<Quote> quotes = new List<Quote>();
            try
            {
                using (StreamReader sr = new StreamReader("Data.txt", System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lines = line.Split('|');
                        quotes.Add(new Quote(lines[0], lines[1]));
                    }
                }
            }
            catch(Exception e)
            {
                CitateLabel.Text = e.Message;
            }
            return quotes;
        }

        void ApllyQuote(Quote quote)
        {
            CitateLabel.Text = "\"" + quote.QuoteText + "\"";
            ByLabel.Content = quote.QuoteAuthor;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Window1 addNewQuote = new Window1();
            addNewQuote.Show();
            //addNewQuote.Activate();
        }
    }
}
