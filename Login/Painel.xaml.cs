    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Xps.Serialization;

    namespace Login;

    public partial class Painel : Window
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void BotaoBuscarImagem(object sender, RoutedEventArgs e)
        {
            string nomeEstudante = tbEstudanteNome.Text;
            
            // Estrutura Switch-case
            switch (nomeEstudante.ToLower())
            {
                case "rebeca spinola":
                    imagemAluna.Source = CriarImagem("https://ichef.bbci.co.uk/ace/ws/640/cpsprodpb/11F73/production/_120878537_4cfca0d7-2b27-474f-93b7-4c31269c5cdf.jpg.webp");
                    break;
                case "sarah":
                    imagemAluna.Source = CriarImagem("https://adimax.com.br/wp-content/uploads/2022/05/cuidados-filhote-de-cachorro.jpg");
                    break;
                case "yatra":
                    imagemAluna.Source = CriarImagem("pack://application:,,,/Images/yatra.jpg");
                    break;
                default:
                    imagemAluna.Source = CriarImagem("pack://application:,,,/Images/padrao.webp");
                    break;
            }
        }

        private static BitmapImage CriarImagem(string url)
        {
            var imagemBitmap = new BitmapImage();
            imagemBitmap.BeginInit();
            imagemBitmap.UriSource = new Uri(url);
            imagemBitmap.EndInit();
            return imagemBitmap;
        } 
    }