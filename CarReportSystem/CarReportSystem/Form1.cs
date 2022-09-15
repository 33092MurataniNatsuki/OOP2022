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
        private void CarReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202209DataSet);
        }

        //設定情報保存用オブジェクト
        Settings settings = Settings.getIndtance();

        int mode = 0;
        public Form1() {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }

        private void pbModeSelect_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルをシリアル化（P305）
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            dgvCarReportDB.Columns[0].Visible = false;



            try {
                //設定ファイルを逆シリアル化（P307）して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);//ARGBからColorオブジェクトへ変換
                }
            }
            catch (Exception) {


            }
            finally { }

            EnabledCheck(); //マスク処理呼び出し
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202209DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuther.Text;
            newRow[3] = GetRadioButtonMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);
            //データセットへ新しいコードを追加
            infosys202209DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202209DataSet.CarReportDB);
        }

        //設定されているメーカーを返す
        private string GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return "トヨタ";
            }
            if (rbNissan.Checked) {
                return "日産";
            }
            if (rbHonda.Checked) {
                return "ホンダ";
            }
            if (rbSubaru.Checked) {
                return "スバル";
            }
            if (rbImport.Checked) {
                return "外国車";
            }
            return "その他";
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューへ設定
            dgvCarReportDB.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReportDB.CurrentRow.Cells[2].Value = cbAuther.Text;
            dgvCarReportDB.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            dgvCarReportDB.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReportDB.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReportDB.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            //dgvCarReportDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgvCarReportDB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //int row_index = 0;
            //dgvCarReportDB.Rows[row_index].Height = pbPicture.Height;
            //int col_index = 0;
            //dgvCarReportDB.Columns[col_index].Width = pbPicture.Width;

            //データセットの中でデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202209DataSet);
        }


        private void btDeleteReport_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow r in dgvCarReportDB.SelectedRows) {
                if (!r.IsNewRow) {
                    dgvCarReportDB.Rows.Remove(r);
                }
            }
            EnabledCheck(); //マスク処理呼び出し

        }

        private void EnabledCheck() {
            btModifyReport.Enabled = btDeleteReport.Enabled = dgvCarReportDB.Rows.Count > 0 ? true : false;

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202209DataSet);
        }

        //コンボボックスに記録者を登録する（重複なし）
        private void setCbAuther(string company) {
            if (!cbAuther.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(company);
            }
        }
        //コンボボックスに車名を登録する（重複なし）
        private void setCbCarName(string company) {
            if (!cbCarName.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(company);
            }
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            ofdCarReportOpen.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = System.Drawing.Image.FromFile(ofdCarReportOpen.FileName);
            }
        }



        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btOpenReport_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202209DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202209DataSet.CarReportDB);

            EnabledCheck();
        }

        private void btSaveReport_Click(object sender, EventArgs e) {
        }

        private void dgvCarReportDB_Click(object sender, EventArgs e) {
            if (dgvCarReportDB.CurrentRow == null) {
                return;
            }

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            dtpDate.Value = (DateTime)dgvCarReportDB.CurrentRow.Cells[1].Value;
            cbAuther.Text = dgvCarReportDB.CurrentRow.Cells[2].Value.ToString();
            var rb = dgvCarReportDB.CurrentRow.Cells[3].Value.ToString();
            RbDisplay(rb);
            cbCarName.Text = dgvCarReportDB.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvCarReportDB.CurrentRow.Cells[5].Value.ToString();
            //画像表示処理
            if (!(dgvCarReportDB.CurrentRow.Cells[6].Value is DBNull)) {
                pbPicture.Image = ByteArrayToImage((byte[])dgvCarReportDB.CurrentRow.Cells[6].Value);
            } else {
                pbPicture.Image = null;
            }
        }

        public void RbDisplay(string rb) {
            if (rb == "トヨタ") {
                rbToyota.Checked = true;
            }
            if (rb == "日産") {
                rbNissan.Checked = true;
            }
            if (rb == "ホンダ") {
                rbHonda.Checked = true;
            }
            if (rb == "スバル") {
                rbSubaru.Checked = true;
            }
            if (rb == "外国車") {
                rbImport.Checked = true;
            }
            if (rb == "その他") {
                rbOther.Checked = true;
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void dgvCarReportDB_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void btNameSearch_Click(object sender, EventArgs e) {
            carReportDBTableAdapter.FillByName(infosys202209DataSet.CarReportDB, tbNameSearch.Text);
        }


    }
}
