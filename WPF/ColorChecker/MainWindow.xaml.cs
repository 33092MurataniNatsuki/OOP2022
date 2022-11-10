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

        List<MyColor> colorList = new List<MyColor>();

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor();
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
                var r = byte.Parse(rValue.Text);
                var g = byte.Parse(gValue.Text);
                var b = byte.Parse(bValue.Text);
                colorLabel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

                //var R = (int)Math.Round(double.Parse(rValue.Text));
                //var G = (int)Math.Round(double.Parse(gValue.Text));
                //var B = (int)Math.Round(double.Parse(bValue.Text));
                //Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
                //colorLabel.Background = new SolidColorBrush(color);
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

        //テキストボックスの値を元に色を設定
        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            Color color = Color.FromRgb(r, g, b);

            colorLabel.Background = new SolidColorBrush(color);
           // colorLabel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void uxColorSelect_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //SampleSlider1.Value = mycolor.Color.R;
            //SampleSlider2.Value = mycolor.Color.G;
            //SampleSlider3.Value = mycolor.Color.B;

            SampleSlider1.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            SampleSlider2.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            SampleSlider3.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;

            setColor();
        }

        private void stock_Click(object sender, RoutedEventArgs e) {
            //stockMyColor.Add(new MyColor() { Name = "R : " + rValue.Text + " G : " + gValue.Text + " B : " + bValue.Text });
            //stockList.Items.Add("R : " + rValue.Text + " G : " + gValue.Text + " B : " + bValue.Text);
            MyColor stColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            stColor.Color = Color.FromRgb(r, g, b);
            
            //テキストボックスのRGB値から色名称があるかチェック
            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R &&
                                            c.Color.G == stColor.Color.G &&
                                            c.Color.B == stColor.Color.B).FirstOrDefault();

            //Insert = コレクションの後ろに追加
            //Add = コレクションの前に追加
            stockList.Items.Insert(0,colorName?.Name ?? "R : " + r + " G : " + g + " B : " + b);
            colorList.Insert(0,stColor);
        }

        private void delete_Click(object sender, RoutedEventArgs e) {
            var dellIndex = stockList.SelectedIndex;

            if (dellIndex == -1)
                return;

            stockList.Items.RemoveAt(dellIndex);
            colorList.RemoveAt(dellIndex);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedItems.Count == 0)
                return;

            SampleSlider1.Value = colorList[stockList.SelectedIndex].Color.R;
            SampleSlider2.Value = colorList[stockList.SelectedIndex].Color.G;
            SampleSlider3.Value = colorList[stockList.SelectedIndex].Color.B;
            setColor();
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
