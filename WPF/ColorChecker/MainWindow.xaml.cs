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

        List<MyColor> stockMyColor = new List<MyColor>();

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
            colorLabel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void uxColorSelect_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            colorLabel.Background = new SolidColorBrush(color);

            rValue.Text = mycolor.Color.R.ToString();
            gValue.Text = mycolor.Color.G.ToString();
            bValue.Text = mycolor.Color.B.ToString();

            //stockMyColor.Add(new MyColor() { Color = color, Name = "R:" + rValue.Text + " " + "G:" + gValue.Text + " " + "B:" + bValue.Text });
            //stockList.Items.Add(mycolor.Name + " " + "R:" + rValue.Text + "G:" + gValue.Text + "B:" + bValue.Text);
        }

        private void stock_Click(object sender, RoutedEventArgs e) {
            //if (uxColorSelect.SelectedItem == null) {
                stockMyColor.Add(new MyColor() { Name = "R : " + rValue.Text + " G : " + gValue.Text + " B : " + bValue.Text });
                stockList.Items.Add("R : " + rValue.Text + " G : " + gValue.Text + " B : " + bValue.Text);
            //} else {
                //stockMyColor.Add(new MyColor() { Color =  , Name = "R:" + rValue.Text + " " + "G:" + gValue.Text + " " + "B:" + bValue.Text });
                //stockList.Items.Add(uxColorSelect.SelectedValue + " " + "R:" + rValue.Text + "G:" + gValue.Text + "B:" + bValue.Text);
            //}

        }

        private void delete_Click(object sender, RoutedEventArgs e) {
            int sel = stockList.SelectedIndex;
            stockList.Items.RemoveAt(sel);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            
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
