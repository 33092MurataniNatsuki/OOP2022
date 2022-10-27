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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        public void chengeSlider() {
            if (rValue != null && gValue != null && bValue != null) {
                var R = (int)Math.Round(double.Parse(rValue.Text));
                var G = (int)Math.Round(double.Parse(gValue.Text));
                var B = (int)Math.Round(double.Parse(bValue.Text));
                rValue.Text = R.ToString();
                gValue.Text = G.ToString();
                bValue.Text = B.ToString();
                Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
                colorLabel.Background = new SolidColorBrush(color);
            }
        }

        private void rValue_TextChanged(object sender, TextChangedEventArgs e) {
            chengeSlider();
        }

        private void gValue_TextChanged(object sender, TextChangedEventArgs e) {
            chengeSlider();
        }

        private void bValue_TextChanged(object sender, TextChangedEventArgs e) {
            chengeSlider();
        }
    }
}
