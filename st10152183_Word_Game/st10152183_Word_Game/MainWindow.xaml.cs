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

namespace st10152183_Word_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string correctAnswer = "";
        static string[] sArray = new string[] { "hardware", "software", "programing", "database", "security", "hacker" };
        public MainWindow()
        {
            InitializeComponent();
           

        }

        private void bntCheck_Click(object sender, RoutedEventArgs e)
        {
            if(txtAnswer.Text.ToLower().Equals( correctAnswer.ToLower()))
            {
                MessageBox.Show("your answer is correct");
            }
            else
            {
                MessageBox.Show("your answer is incorrect");
            }
        }

        private void bntPlay_Click(object sender, RoutedEventArgs e)
        {
            Random rdm=new Random();
            correctAnswer= sArray[rdm.Next(0, sArray.Length)];
            string random = new string(correctAnswer.ToCharArray().OrderBy(x => (rdm.Next(2)%2==0)).ToArray());
            txtLabel.Content = random;
        }

        private void bntClear_Click(object sender, RoutedEventArgs e)
        {
            txtLabel.Content = null;
            txtAnswer.Text = null;
        }

    }
}
