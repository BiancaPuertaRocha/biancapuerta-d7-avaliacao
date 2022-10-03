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

using biancapuerta_d7_avaliacao.Controllers;
using biancapuerta_d7_avaliacao.Data;

namespace biancapuerta_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserController _userController; 
        public MainWindow(Context context)
        {
            InitializeComponent();
            _userController = new UserController(context);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = fieldUser.Text;
            var pass = fieldPass.Password;
            if (user == null || pass == null || user.Trim() == "" || pass.Trim() == "")
            {
                MessageBox.Show("Deve digitar o usuário e a senha!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    var result = _userController.GetLogin(user, pass);
                    if (result == null)
                    {
                        MessageBox.Show("Credenciais inválidas", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuário autenticado!");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro no banco de dados!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }
    }
}
