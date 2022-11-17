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
        Form2 form2;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string url = "https://th.bing.com/th/id/R.d50785b76cbf71572a5e69388e4c90ef?rik=hnX1cBlTqgF7xQ&riu=http%3a%2f%2fwww.kokusaikuyu.co.jp%2fmap%2fmap.png&ehk=BTWmvfel%2bVy6tqj4%2b0TeOOJTxG4IfXFm2G20bo4gInA%3d&risl=&pid=ImgRaw&r=0";
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

        private void btHokkaido_Click(object sender, EventArgs e) {
            tbTihoumei.Text = "宗谷地方";

            //var form = new Form2();
            //this.Hide();

            //if (form.ShowDialog() == DialogResult.Cancel) {
            //    this.Show();
            //}

            using (Form2 subForm = new Form2()) {
                string transfer_string = tbTihoumei.Text;
                subForm.transfer_string = transfer_string;

                subForm.ShowDialog(this);

                transfer_string = subForm.transfer_string;
                tbTihoumei.Text = transfer_string;
            }
        }
    }
}
