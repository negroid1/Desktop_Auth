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

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Login.Text = "";
            Password.Text = "";
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == Login.Text)
            {
                if (Password.Text == Password.Text)
                {
                    if (Code.Text == Code.Text)
                    {
                        return;
                    }
                    else 
                    {
                        MessageBox.Show("Вы ввели неправильный код");
                    }
                }
                else 
                {
                    MessageBox.Show("Вы ввели неправльный пароль");
                }
            }
            else 
            {
                MessageBox.Show("Вы ввели неправльный логин");
            }
        }
    }
}
