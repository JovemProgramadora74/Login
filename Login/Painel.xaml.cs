using System.Windows;

namespace Login;

public partial class Painel : Window
{
    public Painel(string usuario)
    {
        InitializeComponent();
        displayUsuario.Text = usuario.ToUpper();
    }
}