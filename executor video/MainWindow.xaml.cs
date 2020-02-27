using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows;


//using System.Windows.Forms.UI.Xaml.Media;


namespace executor_video
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string video1, video2, video3;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoadMediaFromString(video1);//tela1
            LoadMediaFromString1(video2);//tela2
            LoadMediaFromString2(video3);//tela3
         

            //LoadMediaFromString("C:/Users/danilo/Desktop/Media 1/Portaria 01/Video_1.avi");//tela1
            //LoadMediaFromString1("C:/Users/danilo/Desktop/Media 1/Portaria_02/Video_1.avi");//tela2
            //LoadMediaFromString2("C:/Users/danilo/Desktop/Media 1/Portaria Calcada Esquerda/Video_1.avi");//tela3
         
            btnPlay.Visibility = Visibility.Hidden;
             btnParar.Visibility = Visibility.Visible;
            
          

        }

       public string escolherVideo() {
            // Cria o OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            //Exibi a janela para busca de arquivos
            Nullable<bool> dialogResult = openFileDialog.ShowDialog();

            string CaminhoDoArquivo;

            // Verifica se um arquivo foi selecionado
            if (dialogResult == true)
            {
                // Retorna o path do arquivo selecionado para a variavel CaminhoDoArquivo
                CaminhoDoArquivo = openFileDialog.FileName;

                 return CaminhoDoArquivo;
            }
            return "";
        }
     

        private void LoadMediaFromString(string path)
        {
            try
            {
                Uri pathUri = new Uri(path);
                tela1.Source = pathUri;
                tela1.Play();

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    // handle exception. 
                    // For example: Log error or notify user problem with file
                }
            }
        }

        private void LoadMediaFromString1(string path)
        {
            try
            {
                Uri pathUri = new Uri(path);
                tela2.Source = pathUri;
                tela2.Play();

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    // handle exception. 
                    // For example: Log error or notify user problem with file
                }
            }
        }

        private void LoadMediaFromString2(string path)
        {
            try
            {
                Uri pathUri = new Uri(path);
                tela3.Source = pathUri;
                tela3.Play();

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    // handle exception. 
                    // For example: Log error or notify user problem with file
                }
            }
        }

        private void btnPause_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            tela1.Pause();
            tela2.Pause();
            tela3.Pause();

        }

        private void btnContinue_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            tela1.Play();
            tela2.Play();
            tela3.Play();
        }

        private void btnParar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            tela1.Stop();
            tela2.Stop();
            tela3.Stop();
            btnPlay.Visibility = Visibility.Visible;
            btnParar.Visibility = Visibility.Hidden;
           
        }

        private void btnAbrirVideo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           System.Windows.MessageBox.Show("ESCOLHA O VIDEO PARA EXIBIR NA TELA1.");
          video1=  escolherVideo();

          System.Windows.MessageBox.Show("ESCOLHA O VIDEO PARA EXIBIR NA TALA 2.");
          video2 = escolherVideo();

          System.Windows.MessageBox.Show("ESCOLHA O VIDEO PARA EXIBIR NA TELA 3.");
          video3 = escolherVideo();
        }

        private void sliderTela1_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            tela1.SpeedRatio = (double)sliderTela1.Value;
          
        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                tela1.Position -= TimeSpan.FromSeconds(Convert.ToInt16(txtValor.Text));
                tela2.Position -= TimeSpan.FromSeconds(Convert.ToInt16(txtValor.Text));
                tela3.Position -= TimeSpan.FromSeconds(Convert.ToInt16(txtValor.Text));
            }
            catch { }
        }

        private void sliderTela2_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            tela2.SpeedRatio = (double)sliderTela2.Value;
        }

        private void sliderTela3_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            tela3.SpeedRatio = (double)sliderTela3.Value;
        }

        private void sliderTodasTela_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            tela1.SpeedRatio = (double)sliderTodasTela.Value;
            tela2.SpeedRatio = (double)sliderTodasTela.Value;
            tela3.SpeedRatio = (double)sliderTodasTela.Value;
        }

        private void txtValor_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void btnAvan_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                tela1.Position += TimeSpan.FromSeconds(Convert.ToInt16(txtValor.Text));
                tela2.Position += TimeSpan.FromSeconds(Convert.ToInt16(txtValor.Text));
                tela3.Position += TimeSpan.FromSeconds(Convert.ToInt16(txtValor.Text));
            }
            catch { }
        }

      

       


    }
}
