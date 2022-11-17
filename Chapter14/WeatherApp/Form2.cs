using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();

            //地方のリスト
            cbArea.Items.AddRange(new string[] { "宗谷地方", "上川・留萌地方", "網走・北見・紋別地方",
                                                "釧路・根室地方", "胆振・日高地方",
                                                "石狩・空知・後志地方", "渡島・檜山地方", "青森県",
                                                "岩手県", "宮城県", "秋田県","山形県", "福島県", "茨城県",
                                                "栃木県", "群馬県", "埼玉県", "千葉県", "東京都", "神奈川県",
                                                "山梨県", "長野県", "岐阜県", "静岡県", "愛知県", "三重県",
                                                "新潟県", "富山県", "石川県", "福井県", "滋賀県", "京都府",
                                                "大阪府", "兵庫県", "奈良県", "和歌山県", "鳥取県", "島根県",
                                                "岡山県", "広島県", "徳島県", "香川県", "愛媛県", "高知県",
                                                "山口県", "福岡県", "佐賀県", "長崎県", "熊本県", "大分県",
                                                "宮崎県", "奄美地方", "鹿児島県（奄美地方除く)", "沖縄本島地方",
                                                "大東島地方", "宮古島地方", "八重山地方",
            });

            this.Controls.Add(cbArea);
            this.Text = "Form1";
        }

        private void btWeatherGet_Click_1(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            //エリアコードのリスト
            var list = new List<string>();
            var areaCode = new string[] { "011000","012000","013000","014100","015000","016000","017000","020000",
                                          "030000","040000","050000","060000","070000","080000","090000","100000",
                                          "110000","120000","130000","140000","190000","200000","210000","220000",
                                          "230000","240000","150000","160000","170000","180000","250000","260000",
                                          "270000","280000","290000","300000","310000","320000","330000","340000",
                                          "360000","370000","380000","390000","350000","400000","410000","420000",
                                          "430000","440000","450000","460040","460100","471000","472000","473000","474000",
            };
            list.AddRange(areaCode);

            //areaCodeを使ってURLを作成
            for (int i = 0; i < areaCode.Length; i++) {
                if (cbArea.SelectedIndex == i) {
                    var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + areaCode[i] + ".json");
                    getInfo(dString);
                }
            }

            var dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
            var json2 = JsonConvert.DeserializeObject<Class1[]>(dString1);
            tbTodayWeather.Text = json2[0].timeSeries[0].areas[0].weathers[0];
            tbTomorrowWeather.Text = json2[0].timeSeries[0].areas[0].weathers[1];

            //var list2 = new List<string>();
            //var weatherPic = new string[] { "100", "101", "102", };
            //list2.AddRange(weatherPic);
            //foreach (var item in list2) {
            //    var a = item.Length;
            //    for (int i = 0; i < areaCode.Length; i++) {
            //        if (cbArea.SelectedIndex == i) {
            //            var weatehrCode = json2[0].timeSeries[0].areas[0].weatherCodes[0];
            //            if (a.ToString() == weatehrCode) {
            //                pbWeather.Image = Image.FromFile("https://www.jma.go.jp/bosai/forecast/img/" +areaCode[i] + ".svg");
            //            }
            //        }
            //    }
            //}
        }

        private void getInfo(string dString) {
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            tbpublishingOffice.Text = json.publishingOffice;
            tbreportDatetime.Text = json.reportDatetime.ToString();
            tbTargetArea.Text = json.targetArea;
            tbText.Text = json.text;
        }
    }
}
