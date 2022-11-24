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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            Rootobject2 json3 = getPb();

            pbWeatherMap.ImageLocation = "https://www.jma.go.jp/bosai/weather_map/data/png/" + json3.near.now[0];
        }

        private static Rootobject2 getPb() {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString(@"https://www.jma.go.jp/bosai/weather_map/data/list.json");
            var json3 = JsonConvert.DeserializeObject<Rootobject2>(dString);
            return json3;
        }

        private void button1_Click(object sender, EventArgs e) {
            Rootobject2 json3 = getPb();
            pbWeatherMap.ImageLocation = "https://www.jma.go.jp/bosai/weather_map/data/png/" + json3.near.now[0];
        }

        private void btJapanSirokuro_Click(object sender, EventArgs e) {
            Rootobject2 json3 = getPb();
            pbWeatherMap.ImageLocation = "https://www.jma.go.jp/bosai/weather_map/data/png/" + json3.near_monochrome.now[0];
        }
        private void btAsiaColor_Click(object sender, EventArgs e) {
            Rootobject2 json3 = getPb();
            pbWeatherMap.ImageLocation = "https://www.jma.go.jp/bosai/weather_map/data/png/" + json3.asia.now[0];
        }

        private void btAsiaSirokuro_Click(object sender, EventArgs e) {
            Rootobject2 json3 = getPb();
            pbWeatherMap.ImageLocation = "https://www.jma.go.jp/bosai/weather_map/data/png/" + json3.asia_monochrome.now[0];
        }
    }
}
