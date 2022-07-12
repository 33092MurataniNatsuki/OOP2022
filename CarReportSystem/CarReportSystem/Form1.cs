using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //試乗レポート管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvArticle.DataSource = listCarReport;
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
     //       dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            //if (listPerson.Count() > 0) {
            //    btDelete.Enabled = true;
            //    btUpdate.Enabled = true;
            //}
      //      EnabledCheck(); //マスク処理呼び出し

            setCbAuther(cbAuther.Text);
        }

        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(auther);
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
        private void dgvArticle_Click(object sender, EventArgs e) {
            if (dgvArticle.CurrentRow == null) return;

            int index = dgvArticle.CurrentRow.Index;

            //     dtpDate.Value = listCarReport[index]
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
    }
}
