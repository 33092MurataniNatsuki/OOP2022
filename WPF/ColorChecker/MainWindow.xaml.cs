using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            DataContext = GetColorList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            colorLabel.Background = Brushes.Black;
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public void chengeSlider() {
            if (rValue != null && gValue != null && bValue != null) {
                var R = (int)Math.Round(double.Parse(rValue.Text));
                var G = (int)Math.Round(double.Parse(gValue.Text));
                var B = (int)Math.Round(double.Parse(bValue.Text));
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

        public void changeCombobox() {

        }

        private void uxColorSelect_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            colorLabel.Background = new SolidColorBrush(color);
        }
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
