using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string url = "https://www.holiday-sc.jp/entry/bundles/holidayscwebentry/pc/images/holiday_step1/area_image/japan.gif";
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(url);

            // 画像ファイルをBitmap型として読み込む
            Bitmap bitmap = new Bitmap(stream);
            stream.Close();

            // 画像を表示する
            pbMap.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e) {
            var form = new Form2();
            this.Hide();

            if (form.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        
    }
}
