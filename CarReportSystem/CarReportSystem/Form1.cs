using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        Settings settings = new Settings();

        //試乗レポート管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        int mode = 0;

        public Form1() {
            InitializeComponent();
            dgvArticle.DataSource = listCarReport;
        }

        private void btOpen2_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btDelete2_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void btAdd_Click(object sender, EventArgs e) {
            //記録者が未選択なら登録しない
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("記録者が選択されていません");
                return;
            }

            CarReport newCarReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Maker = GetRadioButtonMakerGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReport.Add(newCarReport);
            dgvArticle.Rows[dgvArticle.RowCount - 1].Selected = true;

            EnabledCheck(); //マスク処理呼び出し

            setCbAuther(cbAuther.Text);
            setCarName(cbCarName.Text);
        }

        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(auther);
            }
        }

        private void setCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(carname);
            }
        }

        private CarReport.MakerGroup GetRadioButtonMakerGroup() {
            //デフォルトの戻りを設定
            CarReport.MakerGroup selectedMakerGroup = CarReport.MakerGroup.その他;
            if (rbToyota.Checked) { //トヨタにチェックがついている
                selectedMakerGroup = CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) { //日産にチェックがついている
                selectedMakerGroup = CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) { //ホンダにチェックがついている
                selectedMakerGroup = CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) { //スバルにチェックがついている
                selectedMakerGroup = CarReport.MakerGroup.スバル;
            }
            if (rbForeighCar.Checked) { //外国車にチェックがついている
                selectedMakerGroup = CarReport.MakerGroup.外国車;
            }
            if (rbOther.Checked) { //その他にチェックがついている
                selectedMakerGroup = CarReport.MakerGroup.その他;
            }
            return selectedMakerGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvArticle_Click_1(object sender, EventArgs e) {
            if (dgvArticle.CurrentRow == null) return;

            int index = dgvArticle.CurrentRow.Index;

            dtpDate.Value = listCarReport[index].Date;
            cbAuther.Text = listCarReport[index].Auther;
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;

            setMakerGroup(index); //番号種別を設定
        }

        private void setMakerGroup(int index) {
            //番号種別チェック処理
            switch (listCarReport[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbForeighCar.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    break;
                default:
                    break;
            }
        }

        private void btCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvArticle.CurrentRow.Index].Date = dtpDate.Value;
            listCarReport[dgvArticle.CurrentRow.Index].Auther = cbAuther.Text;
            listCarReport[dgvArticle.CurrentRow.Index].Maker = GetRadioButtonMakerGroup();
            listCarReport[dgvArticle.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReport[dgvArticle.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgvArticle.CurrentRow.Index].Picture = pbPicture.Image;
            dgvArticle.Refresh();
        }

        private void btDelete1_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvArticle.CurrentRow.Index);

            EnabledCheck(); //マスク処理呼び出し
        }

        private void EnabledCheck() {
            btCorrect.Enabled = btDelete1.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen1_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvArticle.DataSource = null;
                        dgvArticle.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

                cbAuther.Items.Clear(); //コンボボックスのアイテム消去
                //コンボボックスへ新規登録
                foreach (var item in listCarReport.Select(p => p.Auther)) {
                    setCbAuther(item);
                }

                cbCarName.Items.Clear(); //コンボボックスのアイテム消去
                //コンボボックスへ新規登録
                foreach (var item in listCarReport.Select(p => p.CarName)) {
                    setCbAuther(item);
                }
            }
            EnabledCheck(); //マスク処理呼び出し
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb(); //設定オブジェクトへセット
            }
        }

        private void btSize_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++ mode : 0;
            //mode++;
            //if (mode > 4) {
            //    mode = 0;
            //}
        }

        private void Form1_Load(object sender, EventArgs e) {
            //設定ファイルを逆シリアル化して背景の色を設定(P307)
            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                var setting = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(setting.MainFormColor); //ARGBからColorオブジェクトへ変換
            }
            EnabledCheck(); //マスク処理呼び出し
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルをシリアル化(P305)
            using(var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer,settings);
            }
            
        }
    }
}
