using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void progressBar1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(this.MyProgression);
        }


        //Méthode s'exécutant dans un thread séparé, tiré du ThreadPool. ThreadPool est mieux pour utiliser des thread que d'utiliser Thread parce que les thread "en fin de vie"
        //sont réutilisés par la suite dans ThreadPool ce qui n'est pas le cas d'un objet Thread seul.
        private void MyProgression(Object u)
        {
            double min = 0;
            double max = 1;
            double step = 0.1;
            //Dans une méthode séparée anonyme parce qu'on est dans un thread séparé et qu'on ne peut toucher à l'UI qu'a partir du thread de l'UI
            Action method = (Action)delegate
            {
                min = this.progressBar1.Minimum;
                max = this.progressBar1.Maximum;
                step = this.progressBar1.LargeChange;
            };
            //Invoke = Synchrone (bloquant), BeginInvoke = Asynchrone (non-bloquant)
            base.Dispatcher.Invoke(method);//Ici, Invoke parce qu'on veut les valeurs tout de suite et pas plus tard

            //Boucle pour faire progresser ta barre
            for (double i = min; i < max; i += step)
            {
                method = (Action)delegate
                {
                    this.progressBar1.Value = i;
                };
                base.Dispatcher.Invoke(method);//Invoke aussi parce qu'on veut que la valeur soit répercutée de suite et pas plus tard. BeginInvoke pourrait aussi être utilisé mais avec des résultats plus aléatoire, du fait de la notion d'asynchrone.
                Thread.Sleep(300);
            }
        }
    }
}
