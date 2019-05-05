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
using System.Windows.Shapes;
using System.IO;

namespace ProjectMotivator
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Data.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(newQuote.Text + "|" + newAuthor.Text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            newQuote.Text = "";
            newAuthor.Text = "";
        }
    }
}
