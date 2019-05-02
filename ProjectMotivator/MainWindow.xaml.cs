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


        List<Quote> quotes = new List<Quote>();

        public MainWindow()
        {
            InitializeComponent();

            quotes = QuotesFromData();
            ApllyQuote(quotes[5]);
        }

        List<Quote> QuotesFromData()
        {
            List<Quote> quotes = new List<Quote>();
            using (StreamReader sr = new StreamReader("Data.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lines = line.Split('|');
                    quotes.Add(new Quote(lines[0], lines[1]));
                }
            }
            return quotes;
        }

        void ApllyQuote(Quote quote)
        {
            CitateLabel.Content = "\"" + quote.QuoteText + "\"";
            ByLabel.Content = quote.QuoteAuthor;
        }
    }
}
