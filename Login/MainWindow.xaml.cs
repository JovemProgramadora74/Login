using System.Windows;

namespace Login;

public partial class MainWindow : Window
{
    // Inicio Main
    private const string USUARIO_PADRAO = "admin";
    private const string SENHA_PADRAO = "admin";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BotaoLogin(object sender, RoutedEventArgs e)
    {
        // Inicio BotaoLogin
        var usuarioDigitado = tbUsuario.Text;
        var senhaDigitada = tbSenha.Text;

        if (usuarioDigitado == USUARIO_PADRAO && senhaDigitada == SENHA_PADRAO)
        {
            // True
            MessageBox.Show("Boas vindas, Admin");
            var novaJanela = new Painel();
            novaJanela.Show();
        }
        else
        {
            // False
            MessageBox.Show("Usuario e/ou senha estão errados", "Erro");
        }
    } // Fim BotaoLogin
} // Fim Main