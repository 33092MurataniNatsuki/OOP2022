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
    public partial class Form2 : Form {
        public string transfer_string;


        public 天気予報 form1;

        private void Form2_Load(object sender, EventArgs e) {

            lbTihou.Text = transfer_string;

            if (lbTihou.Text == "北海道地方") {
                cbArea.Items.AddRange(new string[] { "宗谷地方", "上川・留萌地方", "網走・北見・紋別地方",
                                                "釧路・根室地方", "胆振・日高地方",
                                                "石狩・空知・後志地方", "渡島・檜山地方",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "東北地方") {
                cbArea.Items.AddRange(new string[] { "青森県","岩手県", "宮城県", "秋田県","山形県", "福島県",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "関東甲信地方") {
                cbArea.Items.AddRange(new string[] { "茨城県","栃木県", "群馬県", "埼玉県", "千葉県", "東京都", "神奈川県","山梨県", "長野県",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "東海地方") {
                cbArea.Items.AddRange(new string[] { "岐阜県", "静岡県", "愛知県", "三重県",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "北陸地方") {
                cbArea.Items.AddRange(new string[] { "新潟県", "富山県", "石川県", "福井県",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "中国地方(山口県を除く)") {
                cbArea.Items.AddRange(new string[] { "滋賀県", "京都府","大阪府", "兵庫県", "奈良県", "和歌山県",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "中国") {
                cbArea.Items.AddRange(new string[] { "鳥取県", "島根県","岡山県", "広島県",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "四国地方") {
                cbArea.Items.AddRange(new string[] { "徳島県", "香川県", "愛媛県", "高知県",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "九州地方(山口県を含む)") {
                cbArea.Items.AddRange(new string[] { "山口県", "福岡県", "佐賀県", "長崎県", "熊本県", "大分県","宮崎県", "奄美地方", "鹿児島県（奄美地方除く)"
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "沖縄地方") {
                cbArea.Items.AddRange(new string[] { "沖縄本島地方","大東島地方", "宮古島地方", "八重山地方",
                });

                this.Controls.Add(cbArea);
                this.Text = "Form1";
            }

            if (lbTihou.Text == "全国") {
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

            var now = System.DateTime.Now;
            today.Text = now.ToString("MM/dd(ddd)");

            var tomorrow = System.DateTime.Today.AddDays(1);
            tomo.Text = tomorrow.ToString("MM/dd(ddd)");

            DateTime dt1 = DateTime.Now;
            dt1 = dt1.AddDays(2);
            tomo2.Text = dt1.ToString("MM/dd(ddd)");

            DateTime dt2 = DateTime.Now;
            dt2 = dt2.AddDays(3);
            tomo3.Text = dt2.ToString("MM/dd(ddd)");

            DateTime dt3 = DateTime.Now;
            dt3 = dt3.AddDays(4);
            tomo4.Text = dt3.ToString("MM/dd(ddd)");

            DateTime dt4 = DateTime.Now;
            dt4 = dt4.AddDays(5);
            tomo5.Text = dt4.ToString("MM/dd(ddd)");
        }

        public Form2() {
            InitializeComponent();
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

            for (int i = 0; i < areaCode.Length; i++) {
                if (cbArea.SelectedIndex == i) {
                    var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + areaCode[i] + ".json");
                    getInfo(dString);

                    var dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + areaCode[i] + ".json");
                    var json2 = JsonConvert.DeserializeObject<Class1[]>(dString1);
                    lbMaxTempToday.Text = json2[1].timeSeries[1].areas[0].tempsMax[1];
                    lbMinTempToday.Text = "-";
                    lbMaxTempTomorrow.Text = json2[1].timeSeries[1].areas[0].tempsMax[2];
                    lbMinTempTomorrow.Text = json2[1].timeSeries[1].areas[0].tempsMin[2];
                    lbMaxT2.Text = json2[1].timeSeries[1].areas[0].tempsMax[3];
                    lbMinT2.Text = json2[1].timeSeries[1].areas[0].tempsMin[3];
                    lbMaxT3.Text = json2[1].timeSeries[1].areas[0].tempsMax[4];
                    lbMinT3.Text = json2[1].timeSeries[1].areas[0].tempsMin[4];
                    lbMaxT4.Text = json2[1].timeSeries[1].areas[0].tempsMax[5];
                    lbMinT4.Text = json2[1].timeSeries[1].areas[0].tempsMin[5];
                    lbMaxT5.Text = json2[1].timeSeries[1].areas[0].tempsMax[6];
                    lbMinT5.Text = json2[1].timeSeries[1].areas[0].tempsMin[6];

                    var todayMark = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[0] + ".png";
                    pbWeatherToday.ImageLocation = todayMark;
                    var TomorrowMark = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[1] + ".png";
                    pbWeatherTomorrow.ImageLocation = TomorrowMark;
                    var TomorrowMark2 = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[2] + ".png";
                    pbWeatherTomorrow2.ImageLocation = TomorrowMark2;
                    var TomorrowMark3 = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[3] + ".png";
                    pbWeatherTomorrow3.ImageLocation = TomorrowMark3;
                    var TomorrowMark4 = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[4] + ".png";
                    pbWeatherTomorrow4.ImageLocation = TomorrowMark4;
                    var TomorrowMark5 = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[5] + ".png";
                    pbWeatherTomorrow5.ImageLocation = TomorrowMark5;


                }
            }
        }

        private void getInfo(string dString) {
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            lbpublishingOffice.Text = json.publishingOffice;
            lbreportDatetime.Text = json.reportDatetime.ToString();
            lbTargetArea.Text = json.targetArea;
            tbText.Text = json.text;
        }
    }
}
