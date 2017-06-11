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

namespace WpfApp11
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Texto_Changed(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (sender as ComboBox);
            ComboBoxItem item = (combo.SelectedItem as ComboBoxItem);
            SolidColorBrush cor = (SolidColorBrush)new BrushConverter().ConvertFromString(item.DataContext as string);

            if (this.Area != null)
            {
                this.Area.Foreground = cor;
            }
        }

        private void Fundo_Changed(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (sender as ComboBox);
            ComboBoxItem item = (combo.SelectedItem as ComboBoxItem);
            SolidColorBrush cor = (SolidColorBrush)new BrushConverter().ConvertFromString(item.DataContext as string);

            if (this.Area != null)
            {
                this.Area.Background = cor;
            }
        }
    }
}
