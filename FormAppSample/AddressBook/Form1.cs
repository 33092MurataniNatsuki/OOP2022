using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listPerson.Add(newPerson);

        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();

            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }

            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            //例
            //データグリッドビューのインデックス０番の名前をテキストボックスに格納
            //tbName.Text = listPerson[0].Name;

            //①選択されているインデックスを取得する
            int index = dgvPersons.CurrentRow.Index;

            //②インデックスが取得出来たら、リスト（listPerson）の該当するインデックスに
            //  アクセスし、リストの各項目を各テキストボックスへ表示する
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            tbCompany.Text = listPerson[index].Company;

            pbPicture.Image = listPerson[index].Picture;

            Clear();
            foreach (var group in listPerson[index].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        break;
                    case Person.GroupType.友人:
                        break;
                    case Person.GroupType.仕事:
                        break;
                    case Person.GroupType.その他:
                        break;
                    default:
                        break;
                }

                if (Person.GroupType.家族 == group) {
                    cbFamily.Checked = true;
                }
                if (Person.GroupType.友人 == group) {
                    cbFriend.Checked = true;
                }
                if (Person.GroupType.仕事 == group) {
                    cbWork.Checked = true;
                }
                if (Person.GroupType.その他 == group) {
                    cbOther.Checked = true;
                }
            }
        }
        private void Clear() {
            cbFamily.Checked = false;
            cbFriend.Checked = false;
            cbWork.Checked = false;
            cbOther.Checked = false;
        }
    }
}
