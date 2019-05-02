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

namespace ProjectMotivator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Quote[] quotes = new Quote[] { new Quote("Дойдя до конца, люди смеются над страхами, мучившими их вначале.", "Пауло Коэльо"),
            new Quote("Если ты не знаешь, чего хочешь, ты в итоге останешься с тем, чего точно не хочешь.", "Чак Паланик"),
            new Quote("Чтобы дойти до цели, надо идти.", "Оноре де Бальзак")};

        public MainWindow()
        {
            InitializeComponent();

            ApllyQuote(quotes[2]);
        }

        void ApllyQuote(Quote quote)
        {
            CitateLabel.Content = "\"" + quote.QuoteText + "\"";
            ByLabel.Content = quote.QuoteAuthor;
            //хоба
        }
    }
}
